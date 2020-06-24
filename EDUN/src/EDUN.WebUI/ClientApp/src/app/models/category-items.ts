import { Item } from './item';

export class CategoryItem {
  id: number;
  name: string;
  total = 0;
  items: Item[];

  constructor(categoryItem: Partial<CategoryItem>) {
    Object.assign(this, categoryItem);

    if (this.items.length > 0) {
      this.total = this.items.map(i => i.value).reduce(function(acc, cur) {
        return acc + cur;
      });
    }
  }
}
