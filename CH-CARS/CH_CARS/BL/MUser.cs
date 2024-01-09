namespace CH_CARS.BL
{
    internal class MUser
    {
        private string name;
        private string password;
        private string role;

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        internal Car Car
        {
            get => default;
            set
            {
            }
        }

        public MUser(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }
        public MUser(string name, string password, string role)
        {
            this.Name = name;
            this.Password = password;
            this.Role = role;
        }
        public string GetName() { return Name; }
        public string GetPassword() { return Password; }
        public string GetRole() { return Role; }
        public void SetName(string name) { this.Name = name; }
        public void SetPassword(string password) { this.Password = password; }
        public void SetRole(string role) { this.Role = role; }
        public bool IsAdmin()
        {
            if (Role == "ADMIN")
            {
                return true;
            }
            else
                return false;
        }

    }
}
