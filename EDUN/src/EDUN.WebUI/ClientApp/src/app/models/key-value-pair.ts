export class KeyValuePair
{
  id: number;
  name: string;

  constructor(keyValuePair?: Partial<KeyValuePair>) {
    Object.assign(this, keyValuePair);
  }
}
