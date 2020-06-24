import { ItemCreate } from './../../models/item-create';
import {Component, OnInit} from '@angular/core';
import { ItemsService } from 'src/app/services/items.service';

@Component({
  selector: 'app-item-form',
  templateUrl: './item-form.component.html',
})
export class ItemFormComponent implements OnInit {
  itemCreate = new ItemCreate();

  constructor(private itemsServie: ItemsService) {
    this.itemCreate.name = 'asdasd';
    this.itemCreate.value = 300;
  }

  ngOnInit() {
  }

  addItem() {
    console.log('NEW ITEM', this.itemCreate);
  }
}
