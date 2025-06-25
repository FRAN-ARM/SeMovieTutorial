namespace SeMovieTutorial.Northwind {
    export enum OrderShippingState {
        NotShipped = 0,
        Shipped = 1
    }
    Serenity.Decorators.registerEnumType(OrderShippingState, 'SeMovieTutorial.Northwind.OrderShippingState', 'Northwind.OrderShippingState');
}

