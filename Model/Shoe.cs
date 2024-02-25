using sneakerszone_api.Model.Root;

namespace sneakerszone_api.Model
{
    public class Shoe : Product
    {
        public string Image { get; set; } = string.Empty;
        public string ImageOver { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
    }
}