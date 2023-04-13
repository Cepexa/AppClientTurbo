using Novell.Directory.Ldap;
using System;

namespace ConsoleApp4
{
    class Program
    {
        public void userList()
        {
            //CN = turbo.ldap,OU = Special accounts,DC = cbg,DC = local
            string ldapHost = "172.17.110.51";
            int ldapPort = 389;
            string loginDN = "CN = Чичиль Сергей Владимирович,OU=SAP_depart,OU=BLG,OU=BLG,OU=CBG,DC=cbg,DC=local";//,OU=Special accounts,DC=cbg,DC=local";//"uid=admin,ou=system";
            string password = "Vohk9tO]";//"Init1234";//"secret";
            string searchBase = "DC = cbg,DC = local";//"OU=BLG,OU = CBG,DC = cbg,DC = local";// "ou=users,o=Company";
            string searchFilter = "name=cbg";//"whenChanged>=20230118074950.0Z";//"sAMAccountName=DomainAdd";//"objectClass=inetOrgPerson";

            try
            {
                //Novell.Directory.Ldap.
                LdapConnection conn = new LdapConnection();
                Console.WriteLine("Connecting to " + ldapHost);
                conn.Connect(ldapHost, ldapPort);
                conn.Bind(loginDN, password);
                string[] requiredAttributes = { "cn", "sn", "sAMAccountName","member","memberOf", "whenChanged", "uSNChanged", "highCommittedUSN" };//"pwdLastSEt"
                LdapSearchResults lsc = (LdapSearchResults)conn.Search(searchBase,
                                    LdapConnection.ScopeSub,
                                    searchFilter,
                                    requiredAttributes,
                                    false);
                while(lsc.HasMore())
                {
                    LdapEntry nextEntry = null;
                    try
                    {
                        nextEntry = lsc.Next();

                    }
                    catch(LdapException e)
                    {
                        Console.WriteLine("Error : " + e.LdapErrorMessage);
                        continue;
                    }
                    Console.WriteLine("\n"+ nextEntry.Dn );
                    LdapAttributeSet attributeSet = nextEntry.GetAttributeSet();
                    System.Collections.IEnumerator ienum = attributeSet.GetEnumerator();
                    while(ienum.MoveNext())
                    {
                        LdapAttribute attribute = (LdapAttribute)ienum.Current;
                        string attributeName = attribute.Name;
                        string attributeVal = attribute.StringValue;
                        Console.WriteLine("\t" + attributeName + "\tvalue  = \t" + attributeVal);
                    }
                }
                conn.Disconnect();


            }
            catch(LdapException e)
            {
                Console.WriteLine("Error :" + e.LdapErrorMessage);
                return;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
                return;
            }
            Console.WriteLine("Press any key ");
            Console.ReadKey(true);
        }
        public void userList83()
        {
            //CN = turbo.ldap,OU = Special accounts,DC = cbg,DC = local
            string ldapHost = "172.31.172.10";
            int ldapPort = 389;
            string loginDN = "CN=turbo.ldap,OU=Special Users,OU=Vsevo,DC=vsevtyres,DC=AD";
            string password = "Gfhjkm123!";
            string searchBase = "OU=Users,OU=Vsevo,DC=vsevtyres,DC=AD";
            string searchFilter = "memberOf=CN=vseopt_maxadmin_u,OU=Optima,OU=Groups,OU=Vsevo,DC=vsevtyres,DC=ad";

            try
            {
                //Novell.Directory.Ldap.
                LdapConnection conn = new LdapConnection();
                Console.WriteLine("Connecting to " + ldapHost);
                conn.Connect(ldapHost, ldapPort);
                conn.Bind(loginDN, password);
                string[] requiredAttributes = { "cn", "sn", "sAMAccountName", "member", "memberOf"};//"pwdLastSEt"
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
                        Console.WriteLine("Error : " + e.LdapErrorMessage);
                        continue;
                    }
                    Console.WriteLine("\n" + nextEntry.Dn);
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
                        Console.WriteLine("\t" + attributeName + "\tvalue  = \t" + attributeVal);
                    }
                }
                conn.Disconnect();
            }
            catch (LdapException e)
            {
                Console.WriteLine("Error :" + e.LdapErrorMessage);
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
                return;
            }
            Console.WriteLine("Press any key ");
            Console.ReadKey(true);
        }

        static void Main(string[] args)
        {
            Program programObj = new Program();
            //programObj.userList83();
            programObj.userList();
        }
    }
}
