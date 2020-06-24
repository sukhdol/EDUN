export class ItemCreate
{
  id: number;
  name: string;
  value: number;
  categoryId: number;

  constructor(itemCreate?: Partial<ItemCreate>) {
    Object.assign(this, itemCreate);
  }
}
