import { Item } from './item';

export class CategoryItem {
  id: number;
  name: string;
  total: number;
  items: Item[];

  constructor(categoryItem: Partial<CategoryItem>) {
    Object.assign(this, categoryItem);
    this.total = this.items.map(i => i.value).reduce(function(acc, cur) {
      return acc + cur;
    });
  }
}
