export class ItemCreate
{
  name: string;
  value: number;
  categoryId: number;

  constructor(itemCreate?: Partial<ItemCreate>) {
    Object.assign(this, itemCreate);
  }
}
