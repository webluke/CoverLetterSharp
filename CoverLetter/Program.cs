// Cover Letter for John Doe - Software Developer
internal class Program {
    static string FullName      = "John Doe";
    static string PhoneNumber   = "(555) 555-5555";
    static string Email         = "john@doe.cool";
    static string Address       = "1234 Elm Street";
    static string CityStateZip  = "Springfield, IL 62701";
    static string LinkedIn      = "https://linkedin.com/in/johndoe";
    static string GitHub        = "https://github.com/johndoe";
    static string Website       = "https://www.johndoe.cool";

    private static async Task Main(string[] args) {
        Console.WriteLine("Hello are you a Software Hiring Manager?");
        Console.WriteLine("Yes or No");
        string response = Console.ReadLine();
        if (response.ToLower() == "yes")
            CoverLetter();
        else
            await BotResponse();
        Console.WriteLine("Thank you for your time.");
        Console.WriteLine("Feel free to reach out to me at (555) 555-5555 or john@doe.cool");
    }
    private static void CoverLetter() {
        Console.WriteLine("Hello Software Hiring Manager,");
        Console.WriteLine(@"
        My name is John Doe and I am a Software Developer with 5 years of experience. 
        Working on creating software that is user-friendly and efficient is my passion. 
        I am excited to bring my skills to your team and help create software that will 
        make a difference.
        ");
        Console.WriteLine(@"
        Recently I worked with C# and WPF to build desktop applications for XYZ Industry 
        to allow them to do Task. Before that I worked with ASP.Net Core building Blazor 
        web applications for XYZ Industry for Task. Beyond recent work I have experience 
        working with Web Development and IT Administration.
        ");
        Console.WriteLine(@"
        This position looks like a great fit for my experience and a place to grow. Feel 
        Free to check out my website at https://www.johndoe.cool, LinkedIn at 
        https://linkedin.com/in/johndoe or my GitHub at https://github.com/johndoe. I look 
        forward to hearing from you soon.    
        ");
        Console.WriteLine("Sincerely, John Doe");        
    }
    private static async Task BotResponse() {
        using (HttpClient client = new HttpClient()) {
            using HttpResponseMessage response = await client.GetAsync(Website);
            response.EnsureSuccessStatusCode();
            string resume = await response.Content.ReadAsStringAsync();
            Console.WriteLine(resume);
        }
    }
}