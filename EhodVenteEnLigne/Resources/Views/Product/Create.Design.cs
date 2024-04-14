using System.ComponentModel;
using System.Globalization;
using System.Resources;

namespace EhodVenteEnLigne.Resources.Models
{

    public class Create
        {
            private static ResourceManager resourceMan;
            private static CultureInfo resourceCulture;

            [EditorBrowsable(EditorBrowsableState.Advanced)]
            public static ResourceManager ResourceManager
            {
                get
                {
                    if (object.ReferenceEquals(resourceMan, null))
                    {
                        ResourceManager temp = new ResourceManager("EhodVenteEnLigne.Resources.Views.Account.Login", typeof(Create).Assembly);
                        resourceMan = temp;
                    }
                    return resourceMan;
                }
            }

            [EditorBrowsable(EditorBrowsableState.Advanced)]
            public static CultureInfo Culture
            {
                get { return resourceCulture; }
                set { resourceCulture = value; }
            }

            public static string ErrorMissingEmail
            {
                get { return ResourceManager.GetString("ErrorMissingEmail", resourceCulture); }
            }

            public static string ErrorMissingPassword
            {
                get { return ResourceManager.GetString("ErrorMissingPassword", resourceCulture); }
            }

        }

}
