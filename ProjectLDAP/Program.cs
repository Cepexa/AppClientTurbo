using System;
using System.Net;
using System.DirectoryServices;
using System.DirectoryServices.Protocols;
using System.Security.Permissions;
using System.Security.AccessControl;

namespace LdapConnection
{
    [DirectoryServicesPermission(SecurityAction.LinkDemand, Unrestricted = true)]
    //[DirectoryServicesPermission(SecurityAction.Assert, Unrestricted = true)]
    public class LdapConnect
    {
        public static void Main(string[] args)
        {
            try
            {
                NetworkCredential nc = new NetworkCredential("CN = turbo.ldap,OU = Special accounts,DC = cbg,DC = local","Init1234");
                System.DirectoryServices.Protocols.LdapConnection ldapConnection = new
                    System.DirectoryServices.Protocols.LdapConnection(
                new LdapDirectoryIdentifier("172.17.110.51", 389),
                nc,
                AuthType.Basic
                );

                string searchFilter = "cn=Чичиль Сергей Владимирович";

                string userStore = "OU=BLG,OU = CBG,DC = cbg,DC = local";

                SearchRequest searchRequest = new SearchRequest
                                (userStore,
                                 searchFilter,
                                 System.DirectoryServices.Protocols.SearchScope.Subtree,
                                 new string[] { "sAMAccountName" });

                var response = (SearchResponse)ldapConnection.SendRequest(searchRequest);
                string userDN = response.Entries[0].Attributes["sAMAccountName"][0].ToString();





                // Create the new LDAP connection
                //LdapDirectoryIdentifier ldi = new LdapDirectoryIdentifier("172.17.65.5", 389);
                //System.DirectoryServices.Protocols.LdapConnection ldapConnection =
                //    new System.DirectoryServices.Protocols.LdapConnection(ldi);
                //Console.WriteLine("LdapConnection is created successfully.");
                //ldapConnection.AuthType = AuthType.Basic;
                //ldapConnection.SessionOptions.ProtocolVersion = 3;
                //NetworkCredential nc = new NetworkCredential("CN=SChichil,DC=cbg.local",
                //    ""); //password
                //ldapConnection.Bind(nc);
                //Console.WriteLine("LdapConnection authentication success");


                //SearchResultCollection sResults = null;

                //DirectoryEntry dEntry = new DirectoryEntry("OU=Special accounts,DC=cbg,DC=local");

                //DirectorySearcher dSearcher = new DirectorySearcher(dEntry);
                //dSearcher.Filter = String.Format("(&(objectClass=user)(cn={0}))", "SChichil");

                //sResults = dSearcher.FindAll();

                //var request = new SearchRequest("ou=Special accounts,dc=cbg,dc=local", "sAMAccountName=DomainAdd", //(objectClass=simpleSecurityObject)
                //              System.DirectoryServices.Protocols.SearchScope.Subtree, null);
                //var response = (SearchResponse)ldapConnection.SendRequest(request);
                //PageResultRequestControl pageRequestControl = new PageResultRequestControl(1000);

                //// used to retrieve the cookie to send for the subsequent request
                //PageResultResponseControl pageResponseControl;
                //SearchRequest request = new SearchRequest();
                //request.Controls.Add(pageRequestControl);
                //var response = (SearchResponse)ldapConnection.SendRequest(request);
                //pageResponseControl = (PageResultResponseControl)response.Controls[0];
                //string searchFilter = "";//String.Format("(&(objectClass=user)(uid={0}))", "");

                //string userStore = "CN=ldap_turbo OU=Special accounts,DC=cbg,DC=local";

                //SearchRequest searchRequest = new SearchRequest();

                //var response = (SearchResponse)ldapConnection.SendRequest(searchRequest);
                //string userDN = response.Entries[0].Attributes["DistinguishedName"][0].ToString();
                //ldapConnection.Dispose();
            }
            catch (LdapException e)
{
    Console.WriteLine("\r\nUnable to login:\r\n\t" + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("\r\nUnexpected exception occured:\r\n\t" + e.GetType() + ":" + e.Message);
}
        }
    }
}



//using System;
//using System.Net;
//using System.DirectoryServices;
//using System.DirectoryServices.Protocols;
//using System.Security.Permissions;

//namespace LdapConnection
//{
//    [DirectoryServicesPermission(SecurityAction.LinkDemand, Unrestricted = true)]
//    public class LdapConnect
//    {

//        public static void Main(string[] args)
//        {
//            try
//            {
//                // Create the new LDAP connection
//                LdapDirectoryIdentifier ldi = new LdapDirectoryIdentifier("172.17.110.50", 389);
//                System.DirectoryServices.Protocols.LdapConnection ldapConnection =
//                    new System.DirectoryServices.Protocols.LdapConnection(ldi);
//                Console.WriteLine("LdapConnection is created successfully.");
//                ldapConnection.AuthType = AuthType.Basic;
//                ldapConnection.SessionOptions.ProtocolVersion = 3;
//                NetworkCredential nc = new NetworkCredential("CN = turbo.ldap,OU = Special accounts,DC = cbg,DC = local",
//                    "Init1234"); //password
//                ldapConnection.Bind(nc);
//                Console.WriteLine("LdapConnection authentication success");
//                var request = new SearchRequest("ou=Special accounts,dc=cbg,dc=local", "", //(objectClass=simpleSecurityObject)
//                              System.DirectoryServices.Protocols.SearchScope.Subtree, null);
//                var response = (SearchResponse)ldapConnection.SendRequest(request);

//                ldapConnection.Dispose();
//            }
//            catch (LdapException e)
//            {
//                Console.WriteLine("\r\nUnable to login:\r\n\t" + e.Message);
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("\r\nUnexpected exception occured:\r\n\t" + e.GetType() + ":" + e.Message);
//            }
//        }
//    }
//}

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
