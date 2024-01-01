using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveLoad {
    
    public static void SavePlayer (PlayerMove player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.sec";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerPosition pos = new PlayerPosition(player);

        formatter.Serialize(stream, pos);
        stream.Close();
    }

    public static PlayerPosition LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.sec";
        if (File.Exists(path))
        {
            ButtonScript.checkButton = true;
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerPosition pos = formatter.Deserialize(stream) as PlayerPosition;
            stream.Close();
            return pos;
        }
        else
        {
            ButtonScript.checkButton = false;
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
