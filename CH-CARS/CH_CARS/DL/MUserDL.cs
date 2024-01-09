using CH_CARS.BL;
using System.Collections.Generic;
using System.IO;

namespace CH_CARS.DL
{
    internal class MUserDL
    {
        static string userFile = "users.txt";
        public static List<MUser> UsersList = new List<MUser>();

        public static void AddToList(MUser user) { UsersList.Add(user); }
        public static void RemoveFromList(MUser user) { UsersList.Remove(user); }
        public static bool StoreInFileUser()
        {
            StreamWriter file = new StreamWriter(userFile, false);
            foreach (MUser user in UsersList)
            {
                file.WriteLine($"{user.GetName()},{user.GetPassword()},{user.GetRole()}");
            }
            file.Flush();
            file.Close();
            return true;
        }
        public static bool ReadFromUserFile()
        {
            StreamReader fileVariable = new StreamReader(userFile);
            string record;
            if (File.Exists(userFile))
            {
                while ((record = fileVariable.ReadLine()) != null)
                {
                    if (record == "")
                    {
                        break;
                    }
                    else
                    {
                        string[] splittedRecord = record.Split(',');
                        string name = splittedRecord[0];
                        string password = splittedRecord[1];
                        string role = splittedRecord[2];
                        MUser user = new MUser(name, password, role);
                        AddToList(user);
                    }
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }
        public static MUser FindUserInList(MUser user)
        {
            foreach (MUser storedUser in UsersList)
            {
                if (user.GetName() == storedUser.GetName()&& user.GetPassword() == storedUser.GetPassword() )
                    return storedUser;
            }
            return null;
        }
        public static MUser FindUserInList(string name)
        {
            foreach (MUser User in UsersList)
            {
                if (name == User.GetName())
                    return User;
            }
            return null;
        }
        public static bool UserExists(MUser user)
        {
            foreach (MUser storedUser in UsersList)
            {
                if (user.GetName() == storedUser.GetName())
                    return true;
            }
            return false;
        }
        public static bool AdminValidation(string word)
        {
            bool flag = true;
            if (word == "ADMIN")
            {
                foreach (MUser user in UsersList)
                {
                    if (word == user.GetRole())
                    {
                        flag = false;
                        break;
                    }
                }
            }
            return flag;
        }
    }
}