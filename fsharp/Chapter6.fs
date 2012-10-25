open System

type Schedule = 
    | Never
    | Once of DateTime
    | Repeatedly of DateTime * TimeSpan

let mapSchedule rescheduleFunc schedule =
    match schedule with
    | Never -> Never
    | Once(eventDate) -> Once(rescheduleFunc(eventDate))
    | Repeatedly(startDate, interval) ->
        Repeatedly(rescheduleFunc(startDate), interval)


ignore(Console.ReadLine())