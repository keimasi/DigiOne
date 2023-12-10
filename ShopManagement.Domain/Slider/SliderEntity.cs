using _0_Framwork.Domain;

namespace ShopManagement.Domain.Slider
{
    public class SliderEntity : EntityBace
    {
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Description { get; private set; }
        public string Link { get; private set; }
        public bool IsRemove { get; private set; }

        public SliderEntity(string picture, string pictureAlt, string pictureTitle, string link, string description)
        {
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Link = link;
            IsRemove = false;
            Description = description;
        }

        public void Edit(string picture, string pictureAlt, string pictureTitle, string link, string description)
        {
            if(!string.IsNullOrWhiteSpace(picture))
                Picture = picture;

            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Link = link;
            Description = description;
        }

        public void Remove()
        {
            IsRemove = true;
        }

        public void Restore()
        {
            IsRemove = false;
        }
    }
}
