Option Strict On
Public Class Car
    Public Shared carCount As Integer
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As String = String.Empty
    Private carPrice As String = String.Empty
    Private carIsNew As Boolean = False
    Private carId As Integer = 0



    Public Sub New()

        carCount += 1    ' increment the shared/static variable counter by 1
        carId = carCount ' assign the carr id

    End Sub

    Public Sub New(make As String, model As String, year As String, price As String, isNew As Boolean)

        ' call the other constructor 
        ' to set the  car count and
        ' to set the car id
        Me.New()


        carMake = make         ' set the car's make
        carModel = model  ' set the the car's model
        carYear = year   ' set the car's year
        carPrice = price ' set the car's price
        carIsNew = isNew     ' set the car is new

    End Sub
    'make the car count to be read only
    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property
    ' make the car id to be read only
    Public ReadOnly Property Id() As Integer
        Get
            Return carId
        End Get
    End Property
    'mamke a make property and use the get and set method
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(value As String)
            carMake = value
        End Set
    End Property
    'mamke a modl property and use the get and set method
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(value As String)
            carModel = value
        End Set
    End Property
    'mamke a year property and use the get and set method
    Public Property Year() As String
        Get
            Return carYear
        End Get
        Set(value As String)
            carYear = value
        End Set
    End Property
    'mamke a price property and use the get and set method
    Public Property Price() As String
        Get
            Return FormatCurrency(carPrice, 2)
        End Get
        Set(value As String)
            carPrice = value
        End Set
    End Property
    'mamke a is newproperty and use the get and set method
    Public Property isNew() As Boolean
        Get
            Return carIsNew
        End Get
        Set(value As Boolean)
            carIsNew = value
        End Set
    End Property
    'mamke a fucntion to show that everythings work message
    Public Function GetSalutation() As String

        Return "It worked!"

    End Function

End Class