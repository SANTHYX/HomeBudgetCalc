export class ExpenseDTO {
  id: string
  title: string
  value: number
  date: Date

  constructor(budgetId: string, title: string, value: number, date: Date) {
    this.id = budgetId;
    this.title = title;
    this.value = value;
    this.date = date;
  }
}
