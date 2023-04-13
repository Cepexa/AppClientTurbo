using System;
using System.Text;
using Novell.Directory.Ldap;

namespace LDAP_Turbo
{
    public  class LDAP_Turbo
    {
        LdapConnection conn;
        public LDAP_Turbo ()
        {
            conn = new LdapConnection();
        }

        public string Connect(string ldapHost, int ldapPort)
        {
            try
            {
                conn = new LdapConnection();
                conn.Connect(ldapHost, ldapPort);
                return "Connect successful";
            }
            catch (Exception e)
            {
                return ErrorText(e);
            }
        }

        public string Disconnect()
        {
            try
            {
                conn.Disconnect();
                return "Disconnect successful";
            }
            catch (Exception e)
            {
                return ErrorText(e);   
            }
        }

        public string Bind(string loginDN, string password)
        {
            try
            {
                conn.Bind(loginDN, password);
                return "Bind successful";
            }
            catch (Exception e)
            {
                return ErrorText(e);
            }
        }

        public string Search(string searchBase, string searchFilter, string requiredAttribute)
        {
            string result = "";
            try
            {
                string[] requiredAttributes = requiredAttribute.Split(',');//{ requiredAttribute };//"pwdLastSEt"
                LdapSearchResults lsc = (LdapSearchResults)conn.Search(searchBase,
                                    LdapConnection.ScopeSub,
                                    searchFilter,
                                    requiredAttributes,
                                    false);
                while (lsc.HasMore())
                {
                    LdapEntry nextEntry = null;
                    try
                    {
                        nextEntry = lsc.Next();

                    }
                    catch (LdapException e)
                    {
                        result += e.LdapErrorMessage + "\n";
                        continue;
                    }
                    string Prep = "{\"dn\":\"" + nextEntry.Dn + "\"" + "\n";
                    string tempValue = "";

                    LdapAttributeSet attributeSet = nextEntry.GetAttributeSet();
                    System.Collections.IEnumerator ienum = attributeSet.GetEnumerator();

                    while (ienum.MoveNext())
                    {
                        LdapAttribute attribute = (LdapAttribute)ienum.Current;
                        string attributeName = attribute.Name;
                        string attributeVal = attribute.StringValue;
                        string[] attributeValArr = attribute.StringValueArray;
                        if (attributeValArr.Length > 1)
                        {
                            attributeVal = "";
                            for (int i = 0; i < attributeValArr.Length; i++)
                            {
                                attributeVal += attributeValArr[i] + "; ";
                            }
                        }
                        tempValue = tempValue + ((tempValue == "") ? "" : ",\n") + "\"" + attributeName + "\":\"" + attributeVal + "\"";
                    }
                    if (tempValue != "")
                    {
                        result = result + ((result == "") ? "" : ",\n") + Prep + ",\"attributes\":{" + tempValue + "}}";
                    }
                }
                return "[" + result + "]";
            }
            catch (Exception e)
            {
                return ErrorText(e);
            }
        }

        private string ErrorText(Exception e)
        {
            var sb = new StringBuilder();
            var ex = e;
            while (ex != null)
            {
                sb.AppendLine(ex.Message);
                ex = ex.InnerException;
            }

            return sb.ToString();
        }

    }

}

//
//public string userList(string ldapHost, int ldapPort)
//{
//    string result = "";
//    string ldapHost1 = "172.17.110.51";
//    int ldapPort1 = 389;
//    string loginDN1 = "CN = turbo.ldap,OU = Special accounts,DC = cbg,DC = local";
//    string password1 = "Init1234";
//    string searchBase = "OU=BLG,OU = CBG,DC = cbg,DC = local";// "ou=users,o=Company";
//    string searchFilter = "";//"sAMAccountName=DomainAdd";//"objectClass=inetOrgPerson";

//    try
//    {
//        LdapConnection conn = new LdapConnection();
//        Console.WriteLine("Connecting to " + ldapHost);
//        conn.Connect(ldapHost1, ldapPort1);
//        conn.Bind(loginDN1, password1);
//        string[] requiredAttributes = { "cn", "sn", "sAMAccountName" };//"pwdLastSEt"
//        LdapSearchResults lsc = (LdapSearchResults)conn.Search(searchBase,
//                            LdapConnection.ScopeSub,
//                            searchFilter,
//                            requiredAttributes,
//                            false);
//        while (lsc.HasMore())
//        {
//            LdapEntry nextEntry = null;
//            try
//            {
//                nextEntry = lsc.Next();

//            }
//            catch (LdapException e)
//            {
//                result = "Error : " + e.LdapErrorMessage;
//                //Console.WriteLine("Error : " + e.LdapErrorMessage);
//                continue;
//            }
//            result = result + "\n" + nextEntry.Dn;
//            //Console.WriteLine("\n" + nextEntry.Dn);
//            LdapAttributeSet attributeSet = nextEntry.GetAttributeSet();
//            System.Collections.IEnumerator ienum = attributeSet.GetEnumerator();
//            while (ienum.MoveNext())
//            {
//                LdapAttribute attribute = (LdapAttribute)ienum.Current;
//                string attributeName = attribute.Name;
//                string attributeVal = attribute.StringValue;
//                result = result + "\t" + attributeName + "\tvalue  = \t" + attributeVal;
//                //Console.WriteLine("\t" + attributeName + "\tvalue  = \t" + attributeVal);
//            }
//        }
//        conn.Disconnect();
//    }
//    catch (LdapException e)
//    {
//        //Console.WriteLine("Error :" + e.LdapErrorMessage);
//        return "Error :" + e.LdapErrorMessage;
//    }
//    catch (Exception e)
//    {
//        //Console.WriteLine("Error :" + e.Message);
//        return "Error :" + e.Message;
//    }
//    return result;
//    //Console.WriteLine("Press any key ");
//    //Console.ReadKey(true);
//}