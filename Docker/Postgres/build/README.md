# Описание
[Образ flexberry/alt.p8-postgresql](https://hub.docker.com/r/flexberry/alt.p8-postgresql/) поддерживает функционал базы данных Postgres.

Характерные особенности образа:
- в качестве базового образа используется  [образ дистрибутив ALTLinux P8](https://hub.docker.com/r/fotengauer/altlinux-p8/). входяшего  в [Единый реестр российских программ для электронных вычислительных машин и баз данных](https://reestr.minsvyaz.ru/);
- задание основных параметров конфигурации при запуске контейнера путем определения параметров среды. 

## Запуск образа в виде swarm сервиса

### Описание сервиса

При запуске образа в виде swarm сервиса можно вопользоваться следующим шаблоном YML-файла описания серисов:
```
version: '3.2'
services:
  postgres:
    image: flexberry/alt.p8-postgresql
    ports:
      - 5432:5432
    deploy:
      placement:
        constraints:
          - node.labels.role == database
          - node.hostname == postgres
    volumes:
      - db:/var/lib/pgsql/data/
      - /etc/localtime:/etc/localtime
    environment:
      - POSTGRES_max_connections=250
      - ...

volumes:
  db:
```

Описание `ports` необходимо в том случае, когда к базе данных необходим доступ извне стека сервисов.
Если доступ к базе данных осуществяется только в рамках сервисов, описанных в стеке, то с целью повышения защищенности создаваемого решения проброс порта 5432 для внешнего доступа желательно исключить. В рамках стека сервисов обращение к базе данных осуществляется по имени сервсиа (в данном случае postges).

Если стек сервисов функционирует в кластере включающем более одного активного узла, то необходим описатель `deploy/placement/constraints`, в котором с помощью описателей `node.labels`, `node.hostname` и других необходимо **однозначно** определить узел на котором будет функционировать сервис и располагаться база данных. В данном случае мы ограничиваем запуск сервиса только узлом имеющим роль database и hostname postgres.
Если ряд узлов в кластере поддерживают доступ к разделяемой файловой системе (GFS2, ...), то возможен альтернытивный запуск сервсиа на одном из узлов. В этом случае узлы помечаются меткой (role) и в условии constaints: указывается заданная метка узла. 
Если сервис запускается в кластере, состоящим из одного узла описатель `deploy/placement/constraints` не обязатален.

Укзанный сервис немасштабируем (scale=1). Если Вам в рамках одного стека необходим запуск несколькиз Postgres-серверов достаточно описать несколько сервсиов:
```
version: '3.2'
services:
  postgres1:
    ...
  postges2:
  ...
```
При запуске сервиса **обязвтельно** необходимо каталог базы данных `/var/lib/pgsql/data/` с помощью описателя `volumes` смонтировать на каталог HOST-системы. DВ противном случае Вы потеряете содержимое базы данных после рестарта контейнера сервиса.
Для этого очень удобно использовать именованные тома (в нашем случае db). 
Если указанный именованный том не существует docker обеспечит его автоматическое создание и копирование содержимого каталога `/var/lib/pgsql/data/`  в именованный том. При использовании другим механизмов монтирования перед запуском сервиса необходимо обеспечить копирование каталога `/var/lib/pgsql/data/` в монтируемый том.

Монтирование файла `/etc/localtime` сервиса на аналогичный файл HOST-системы обечпечивает соответствие временной зоны контейнера сервиса временной зоне HOST_системы. 

Перед запуском сервера postres в контейнере сервиса инициализационный скрипт проверяет наличие в среде переменных с префиксом `POTGRRES_`. У найденных переменных удаляется указанный префикс и в файле конфигурации `postgresql.conf` заменяет значение переменнлй клнфигурации на указаное в переменной среды. В нашем примере параметр конфигурации `max_connections` конфигурационного файла `postgresql.conf` будет установлен в значение `250`.
На настоящий момент не поддерживается задание параметров конфигурации, включающих в имя символы `:`, '.'. В случае необходимости установки таких параметров возможна правка самого файла конфигурации `postgresql.conf`, распоможенного в именованном томе.

### Варианты "проброса" порта базы данных для внешнего доступа

### Запуск сервиса

### Останов сервиса

### Обноваление сервиса

## Запуск образа в виде контейнера

### Параметры запуска 

### Запуск контейнера

### Останов контейнера

## Tips&Tricks

### Запуск команд внутри работающего контейнера
