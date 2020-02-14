export interface Pagination {
    currentPage: number;
    itemsPerPage: number;
    totalItems: number;
    totalPages: number;
}

export class PaginatiedResult<T> {
    result: T;
    pagination: Pagination;
}
