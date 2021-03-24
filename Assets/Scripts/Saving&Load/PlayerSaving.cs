using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class PlayerSaving
{
    public static void SavePlayer1(Character player1)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player1.dta";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerSaveScript data1 = new PlayerSaveScript(player1);
        formatter.Serialize(stream, data1);
        stream.Close();
    }
    public static void SavePlayer2(HeroGenerationUIScript player2)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player2.dta";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerSaveScript data2 = new PlayerSaveScript(player2);
        formatter.Serialize(stream, data2);
        stream.Close();
    }

    public static PlayerSaveScript LoadPlayer1()
    {
        string path = Application.persistentDataPath + "/player1.dta";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerSaveScript data1 = formatter.Deserialize(stream) as PlayerSaveScript;
            stream.Close();
            return data1;
        }
        else
        {
            Debug.LogError("Plik zapisu nie znaleziony!" + path);
            return null;
        }
    }

    public static PlayerSaveScript LoadPlayer2()
    {
        string path = Application.persistentDataPath + "/player2.dta";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerSaveScript data2 = formatter.Deserialize(stream) as PlayerSaveScript;
            stream.Close();
            return data2;
        }
        else
        {
            Debug.LogError("Plik zapisu nie znaleziony!" + path);
            return null;
        }
    }
}