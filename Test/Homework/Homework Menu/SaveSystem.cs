using Newtonsoft.Json;

namespace Test.Homework.Homework_Menu
{
    public static class SaveSystem
    {
        private const string filePath = "C:\\Users\\Admin\\Desktop\\save.json";

        public static void Save(List<User> users)
        {
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static List<User> Load()
        {
            if (File.Exists(filePath) == false)
            {
                TaskUtils.ShowText("Не удалось найти файл");
                return new List<User>();
            }
            string json = File.ReadAllText(filePath);
            if (string.IsNullOrEmpty(json) == true)
            {
                TaskUtils.ShowText("Не удалось загрузить данные");
                return new List<User>();
            }
            List<User>? users = JsonConvert.DeserializeObject<List<User>>(json);
            if (users == null)
            {
                TaskUtils.ShowText("Не удалось десерелизировать");
                return new List<User>();
            }
            return users;
        }
    }
}
