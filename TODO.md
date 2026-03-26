# TODO: Реализация поиска, сортировки, фильтрации товаров + добавление/редактирование только для админа

## План выполнения (approved):

**Information Gathered**: ...
(full plan summary here but short)

## Шаги:
- [x] 1. План утвержден пользователем.
- [x] TODO.md создан/обновлен.

- [x] 2. Обновить FormProducts.Designer.cs: Добавить UI элементы (txtSearch, lblSearch, cmbSupplierFilter, lblSupplierFilter, cboSortStock, lblSortStock) в panelTop.

- [x] 3. Обновить FormProducts.cs: 
  - Добавить поля для controls и состояний (_currentSearch, _currentSupplierId, _currentSort).
  - В ctor: LoadFilterControls(), role-based visibility.
  - Новый метод LoadFilteredProducts(string search, int? supplierId, string sortDir).
  - Events: TextChanged, SelectedIndexChanged.
  - Admin check в BtnCreate_Click, BtnUpdate_Click.

- [ ] 4. Проверить роли (if needed, query DB for RoleNames).

- [ ] 5. Тестирование: build, run, verify real-time, roles.

- [ ] 6. Завершить задачу (attempt_completion).

**Заметки**:
- Роли: "Администратор", "Менеджер".
- Stock field: CointInStok.
- Real-time: events call LoadFilteredProducts with current state.

