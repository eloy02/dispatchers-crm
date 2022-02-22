# dispatchers-crm

Приложение для приема и учета заявок диспетчерского центра. 

Попытка написать свой вариант приложения с учетом возникших ранее ошибок

**Внимание проект для тренировки и опробирования новых библиотех, технологий, архитектурных моментов**

**Проект делается в свободное от работы время и не имеет чётких границ по времени**

## Roadmap

- [ ] Авторизация и идентификация пользователя
- [ ] Админка с возможностью редактирования справочников приложения и в будущем настроек приложения
- [ ] Страница со списком заявок
- [ ] Страница создания заявки
- [ ] Интеграция с ФИАС
- [ ] Интеграция с телефонией
- [ ] Отчеты


## Немного о структуре проекта

Проект с клиент-серверной архитектурой. Планируется использовать [Mediatr](https://github.com/jbogard/MediatR) и CQRS паттерн архитектуры проекта.

Модель данных приложения будет описана в классах, с использованием [protobuf-net.Grpc](https://github.com/protobuf-net/protobuf-net.Grpc) для последующего использования в качестве контрактов в grpc сервисе.

Клиентская часть - прилодение написанное с использованием Blazor WebAssembly - `Dispatchers.App.BlazorWebAssembly`. Общаться прилоение с серверной частью  будет через grpc.

`Dispatchers.Core` - проект, где будут описываться все модели, контракты запросов и команд для Mediatr, интерфейсы сервисов.
`Dispatchers.Database` - проект для моделей БД, расширений, DbContext.
`Dispatchers.App.Core` - проект для ViewModel-ей приложения, реализации провайдера загрузки данных из сервиса приложения.

# English

An attempt to create an application for receiving and accounting dispatcher center requests.

**Attention! The project is for training and testing new libraries, technologies, architectural moments.**

**The project is written in my spare time and has no clear time limits**

## Roadmap

- [ ] Authorization and user identification
- [ ] Admin panel with the ability to edit application directories and application settings
- [ ] A page with a list of requests
- [ ] Requests creation page
- [ ] Integration with https://fias.nalog.ru/ database
- [ ] Integration with telephony
- [ ] Reports

## Something about the structure of the project

A client-server architecture project. It is planned to use [Mediatr](https://github.com/board/MediatR) and CQRS project architecture pattern.

The application data model will be described in classes using [protobuf-net.Grpc](https://github.com/protobuf-net/protobuf-net.Grpc ) for subsequent use as contracts in the grpc service.



