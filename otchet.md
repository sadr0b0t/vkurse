Отчет по первому заданию группе XML Web-Services
XML - Расширяемый язык разметки, предназначенный для хранения и передачи структурированных данных;
Web-service - программная система, идентифицируемая строкой URL, чьи общедоступные интерфейсы определены на языке XML;
SOAP - Протокол обмена сообщениями на базе XML;
Tomcat – используется в качестве веб-сервера; Axis – реализация SOAP;
Xerces — семейство программных пакетов для синтаксического анализа и работы с XML;

Установка Apache Axis на Tomcat:
Всю установку Apache Axis на сервер-приложений Tomcat можно свести к простой разархивации дистрибутива и копированию библиотек Axis из каталога lib/ в common/lib/ и каталога webapps/axis/ в каталог webapps/ сервера Tomcat. После этого Tomcat будет работать еще и как SOAP- и WSDL-сервер. Так же нужно скопировать xml-apis.jar и xercesImpl.jar из  дистрибутива Xerces в webapps/axis/ сервера Tomcat.  Необходимо так же скопировать файл tools.jar из дистрибутива Java в каталог в webapps/axis/ сервера Tomcat.
Среда разработки: IDE Eclipse

Установка нового веб-сервиса:
Установка нового Веб-сервиса требует описания класса на языке Java. В классе реализована функция, которая печатает полученные значения переменных (Факультет, группа) в требуемом формате. Файл NameOfFile, с написанным классом, помещаем в каталог webapps/axis/ сервера Tomcat с расширением JWS (Java Web-Service). Наш сервер теперь доступен по адресу: http://localhost:8080/axis/NameOfFile.jws

Создание приложения Java для реализации запросов к веб-сервису:
Доступ к веб-сервису на языке Java реализовываем динамически с помощью метода Call из библиотеки Axis.jar. Перед созданием класса импортируем библиотеки axis.jar и xml-apis.jar  Создаем класс, который обращается к веб-сервису по указанному выше адресу и вызывает метод из класса веб-сервиса. Затем передаем ему параметры и получаем ответ с помощью метода call.invoke(). Печатаем ответ в консоле IDE Eclipse.
Код JWS:
public class SampleTask {
> public String sayAnswer(String department,int group){
> return "My Department: " + department + ";" + "My Group: " + group;
> }
}
Код  Java-приложения:
package sample\_task;
import org.apache.axis.client.Call;
import org.apache.axis.client.Service;
import javax.xml.namespace.QName;
import java.net.URL;
public class SampleTaskRun {
public static void main(String[.md](.md) args) {
> try {
String endpoint = "http://localhost:8080/axis/SampleTask.jws";
> > Service service = new Service();
Call call = (Call) service.createCall();
> > call.setOperationName(new QName("http://localhost:8080/axis/SampleTask.jws", "sayAnswer" ));
> > call.setTargetEndpointAddress(new URL(endpoint));
Object[.md](.md) params = new Object[.md](.md){"FIVT", 794};
> > > String response = (String)call.invoke("sayAnswer", params);
System.out.println(response);
System.out.println("All done!");

> } catch (Exception exception) {
> System.err.println("Caught an exception: " + exception);
> }
> > }
}
В итоге, в консоле Eclipse мы получаем:
My Department: FIVT;My Group: 794
All done!
Полезные ссылки:
http://ws.apache.org/axis/java/install.html
http://lib.juga.ru/article/view/190/