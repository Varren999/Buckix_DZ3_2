namespace Buckix_DZ3_2
{
    internal class Website
    {
        private string name;
        public string Name { get => name; set { name = value; } }

        private string path;
        public string Path { get => path; set { path = value; } }

        string note;
        public string Note { get => note; set { note = value; } }

        string ip;
        public string Ip { get => ip; set { ip = value; } }

        public override string ToString() => $"Название сайта: {Name}\nАдрес сайта: {Path}\nОписание: {Note}\nIP: {Ip}";
    }
}
