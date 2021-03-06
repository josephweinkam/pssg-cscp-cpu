import { iSurplusItem } from "./surplus-item.interface";

export class SurplusItem implements iSurplusItem {
    id: string;
    surplus_plan_id: string;
    name?: string;
    expense_name?: string;
    proposed_amount: number;
    proposed_amount_mask: string;
    allocated_amount: number;
    allocated_amount_mask: string;
    justification?: string;
    expenditures_q1?: number;
    q1_mask: string;
    expenditures_q2?: number;
    q2_mask: string;
    expenditures_q3?: number;
    q3_mask: string;
    expenditures_q4?: number;
    q4_mask: string;

    constructor(si?: iSurplusItem) {
        if (si) {
            Object.assign(this, si);
        }
    }
}