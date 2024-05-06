namespace Learning.Date.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription {  get; set; }
        public string LongDescription { get; set; }
        public string Image {  get; set; }
        public ushort Price {  get; set; } //ushort, чтобы небыло отрицательного значения цены
        public bool IsFavourite {  get; set; } //отображение в блоке лучшие товары
        public bool Available {  get; set; } //доступен ли товар на складе
        public int CategoryID {  get; set; } //присваивание товару категории
        public virtual Category Category { get; set; } //создание объекта к категории
    }
}
