Public Interface IObservador
    'Define el método que usa el sujeto para notificar cambios en su estado (update/notify).
    Sub UpdateState(ByVal sender As SujetoConcreto)

End Interface