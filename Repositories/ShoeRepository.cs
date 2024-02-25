using sneakerszone_api.Model;

namespace sneakerszone_api.Repositories
{
    public static class ShoeRepository
    {
        private static readonly List<Shoe> _shoes = new()
        {
            new Shoe
            {
                Id = 1,
                Description = "Nike Air Jordan 1 Mid",
                Image = "",
                ImageOver = "",
                Type = "Sneakers",
                Value = "119,99"
            },
            new Shoe
            {
                Id = 2,
                Description = "Air Jordan Legacy 312 Low",
                Image = "",
                ImageOver = "",
                Type = "Sneakers",
                Value = "149,99"
            },
            new Shoe
            {
                Id = 3,
                Description = "Air Force 1 '07",
                Image = "",
                ImageOver = "",
                Type = "Sneakers",
                Value = "89,99"
            },
            new Shoe
            {
                Id = 4,
                Description = "Adidas Forum Low CL",
                Image = "",
                ImageOver = "",
                Type = "Sneakers",
                Value = "120,00"
            },
            new Shoe
            {
                Id = 5,
                Description = "Nike Shox 12 Molas",
                Image = "",
                ImageOver = "",
                Type = "Sneakers",
                Value = "127,32"
            }
        };

        public static void AddShoe(Shoe shoe){
            _shoes.Add(shoe);
        }

        public static void UpdateShoe(Shoe shoe){
            var shoeOfList = _shoes.FirstOrDefault(x => x.Id == shoe.Id) ?? throw new BadHttpRequestException($"Sapato não encontrado.");

            _shoes.Remove(shoeOfList);
            _shoes.Add(shoe);
        }

        public static List<Shoe> GetAll(){
            return _shoes;
        }

        public static Shoe GetById(int id){
            return _shoes.FirstOrDefault(x => x.Id == id) ?? throw new BadHttpRequestException($"Sapato de identificador: {id} não encontrado.");
        }
    }
}