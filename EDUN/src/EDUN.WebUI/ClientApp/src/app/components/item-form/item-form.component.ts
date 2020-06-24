import { KeyValuePair } from './../../models/key-value-pair';
import { CategoriesService } from 'src/app/services/categories.service';
import { ItemCreate } from './../../models/item-create';
import {Component, OnInit} from '@angular/core';
import { ItemsService } from 'src/app/services/items.service';

@Component({
  selector: 'app-item-form',
  templateUrl: './item-form.component.html',
})
export class ItemFormComponent implements OnInit {
  itemCreate = new ItemCreate();
  categories = new Array<KeyValuePair>();

  constructor(private itemsServie: ItemsService,
              private categoryService: CategoriesService) {
  }

  ngOnInit() {
    this.getCategoryOptions();
  }

  addItem() {
    console.log('NEW ITEM', this.itemCreate);
  }

  getCategoryOptions() {
    this.categoryService.getCategoriesKeyValuePair().subscribe(keyValuePairs => {
      this.categories = new Array<KeyValuePair>();
      keyValuePairs.forEach(keyValuePair => {
        this.categories.push(new KeyValuePair(keyValuePair));
      });
    });
  }
}
