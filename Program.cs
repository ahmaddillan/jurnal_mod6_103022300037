using System.Security.Cryptography;

public class sayaTubeUser {
    private int id;
    private List<sayaTubeVideo> uploadedVideos = new List<sayaTubeVideo>();
    public String Username;

    public sayaTubeUser(String nama){
        this.Username = nama;
    }

    public int getTotalVideoPlayCount() {
        int jum = 0;
        for (int i = 0; i < uploadedVideos.Count; i++) {
            
            jum += uploadedVideos[i].playCount;
        }
        return jum;
    }

    public void addVideo(sayaTubeVideo video ) {
        uploadedVideos.Add(video);
    }

    public void PrintVideoPlayCount()
    {
        Console.WriteLine(Username);
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
          uploadedVideos[i].PrintVideoDetails();
        }
    }
}

public class sayaTubeVideo {
    private int id;
    private String title;
    public int playCount;

    public sayaTubeVideo(String title)
    {
        Random random = new Random();
        this.title = title;
        this.id = random.Next(10000, 10000);
    }

    public void increasePlayCount(int count) {
        this.playCount += count;
    }

    public void PrintVideoDetails() {
        Console.WriteLine("judul: " + title);
        Console.WriteLine("ID video: " + id);
        Console.WriteLine("play Count: " + playCount);
    }
}

public class program {
    public static void Main() {
        sayaTubeUser user = new sayaTubeUser("Dillan");
        sayaTubeVideo vid = new sayaTubeVideo("berserk");
        sayaTubeVideo vid2 = new sayaTubeVideo("arifureta");
        sayaTubeVideo vid3 = new sayaTubeVideo("kimi no nawa");
        sayaTubeVideo vid4 = new sayaTubeVideo("what do use wish with does murky eye");

        Console.WriteLine((user.getTotalVideoPlayCount().ToString()));

        vid.increasePlayCount(user.getTotalVideoPlayCount());
        user.addVideo(vid);
        user.addVideo(vid2);
        user.addVideo(vid3);
        user.addVideo(vid4);

        user.PrintVideoPlayCount();
    }
}