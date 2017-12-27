Public Interface iSujeto
    'El sujeto concreto proporciona una interfaz para agregar (attach) y eliminar (detach) observadores.
    'El Sujeto conoce a todos sus observadores.
    Sub Notify()
    Sub Subscribe(ByVal observer As IObservador)
    Sub Unsubscribe(ByVal observer As IObservador)
End Interface
