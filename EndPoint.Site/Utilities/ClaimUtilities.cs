using System.Security.Claims;

namespace EndPoint.Site.Utilities
{
    public static class ClaimUtilities
    {
        public static long? GetUserID(ClaimsPrincipal user)
        {
            var claimidentity = user.Identity as ClaimsIdentity;
            long id;
            if (claimidentity.FindFirst(ClaimTypes.NameIdentifier) != null)
            {
                long.TryParse(claimidentity.FindFirst(ClaimTypes.NameIdentifier).Value, out id);
                return id;
            }
            else
            {
                return null;
            }
        }
    }
}
