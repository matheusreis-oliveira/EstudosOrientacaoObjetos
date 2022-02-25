using POO.SharedContext;

namespace POO.ContentContext
{
    // classe content é abstrata, não é possivel instanciar ela em nenhum local, apenas se baseando nas classes que herdam content
    public abstract class Content : Base
    {
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}