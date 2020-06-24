import { KeyValuePair } from './../../models/key-value-pair';
import { CategoriesService } from 'src/app/services/categories.service';
import { ItemCreate } from './../../models/item-create';
import {Component, OnInit, Output, EventEmitter} from '@angular/core';
import { ItemsService } from 'src/app/services/items.service';

@Component({
  selector: 'app-item-form',
  templateUrl: './item-form.component.html',
})
export class ItemFormComponent implements OnInit {
  @Output() addItemEvent = new EventEmitter();

  itemCreate = new ItemCreate();
  categories = new Array<KeyValuePair>();

  constructor(private itemsServie: ItemsService,
              private categoryService: CategoriesService) {
  }

  ngOnInit() {
    this.getCategoryOptions();
  }

  addItem() {
    this.itemCreate.categoryId = +this.itemCreate.categoryId;
    this.itemsServie.create(this.itemCreate).subscribe(item => {
      this.addItemEvent.emit(item);
    });
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
