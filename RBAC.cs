using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
sealed class RoleAllowedAttribute : Attribute
{
    public string AllowedRole { get; }

    public RoleAllowedAttribute(string allowedRole)
    {
        AllowedRole = allowedRole;
    }
}

class UserAccess
{
    public string CurrentRole { get; set; }

    public UserAccess(string role)
    {
        CurrentRole = role;
    }

    [RoleAllowed("ADMIN")]
    public void AdminMethod()
    {
        Console.WriteLine("Access granted to Admin method.");
    }

    [RoleAllowed("USER")]
    public void UserMethod()
    {
        Console.WriteLine("Access granted to User method.");
    }

    public void InvokeMethod(string methodName)
    {
        // Use reflection to get the method information
        MethodInfo method = this.GetType().GetMethod(methodName);

        // Check if the method has the RoleAllowed attribute
        var attribute = (RoleAllowedAttribute)Attribute.GetCustomAttribute(method, typeof(RoleAllowedAttribute));

        if (attribute != null)
        {
            // Check if the current role matches the allowed role for the method
            if (CurrentRole == attribute.AllowedRole)
            {
                method.Invoke(this, null);
            }
            else
            {
                Console.WriteLine("Access Denied!");
            }
        }
        else
        {
            Console.WriteLine("No role restriction for this method.");
        }
    }
}
class Program10
{
   /* static void Main(string[] args)
    {
        // Create users with different roles
        UserAccess adminUser = new UserAccess("ADMIN");
        UserAccess normalUser = new UserAccess("USER");

        // Try invoking AdminMethod with different users
        Console.WriteLine("Admin trying to access AdminMethod:");
        adminUser.InvokeMethod("AdminMethod");

        Console.WriteLine("\nNormal User trying to access AdminMethod:");
        normalUser.InvokeMethod("AdminMethod");

        // Try invoking UserMethod with different users
        Console.WriteLine("\nAdmin trying to access UserMethod:");
        adminUser.InvokeMethod("UserMethod");

        Console.WriteLine("\nNormal User trying to access UserMethod:");
        normalUser.InvokeMethod("UserMethod");
    }*/
}
