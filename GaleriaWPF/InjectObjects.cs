using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleriaWPF
{
    public class InjectObjects
    {
        public InjectObjects()
        {
            Insert();
        }

        public List<Gallery> galleries = new List<Gallery>();
        public void Insert()
        {
            galleries.Add(new Gallery
            {
                CatID = 1,
                SubCatID = 1,
                SubCat = "Słodkowodne",
                SubCatUrl = "img/bolen.jpg",
                Photos = new ObservableCollection<Photo>() {
                    new Photo() { Name = "Boleń", Description = "Długie, wyciągnięte, bocznie nieco spłaszczone ciało. Głowa spiczasta, oczy małe. Szeroki, końcowo położony otwór gębowy. Nieco wysunięta szczęka dolna ma na końcu garbikowate zgrubienie, chowające się we wgłębieniu szczęki górnej.", Url = "img/bolen.jpg" },
                    new Photo() { Name = "Brzana", Description = "Ciało wyciągnięte, smukłe, słabo wygrzbiecone o prawie prostej linii brzucha. Pysk ryjkowaty, wydłużony. Otwór gębowy dolny z grubymi, mięsistymi wargami, na krawędzi wargi górnej znajdują się cztery wąsiki. Łuski średniej wielkości, 55-65 wzdłuż linii bocznej. Płetwa grzbietowa krótka z 11-12 promieniami. Pierwszy jest najdłuższy i pogrubiony, na tylnej krawędzi piłkowany.", Url = "img/brzana.jpg" },
                    new Photo() { Name = "Karaś", Description = "Ciało silnie wygrzbiecone, krępe, bocznie ścieśnione. Brak wąsów. Łuski duże, 31-55 wzdłuż linii bocznej. Płetwa grzbietowa wysoka z 17-25 promieniami. Jej górna krawędź jest wypukła. Pierwszy promień miękki, giętki, na tylnej krawędzi lekko piłkowany.", Url = "img/karas.jpg" },
                    new Photo() { Name = "Leszcz", Description = "Silnie wygrzbiecone, bocznie równie silnie ścieśnione ciało o tępym pysku i prawie dolnie ustawionym otworze gębowym. Średnica oka mniejsza od długości pyska. Łuski duże. 50-57 wzdłuż linii bocznej. Płetwa grzbietowa z 12, a odbytowa z 26-31 promieniami. Płetwy piersiowe sięgają do nasady płetw brzusznych. Zęby gardłowe jednorzędowe, 5-5.", Url = "img/leszcz.jpg" },
                    new Photo() { Name = "Szczupak", Description = "Bardzo silnie wydłużone, bocznie słabo ścieśnione ciało, o przesuniętej daleko ku tyłowi płetwie grzbietowej. Brak płetwy tłuszczowej. Płetwy grzbietowa i odbytowa ustawiona naprzeciw siebie. Płetwa ogonowa rozwidlona. Długa głowa, o pysku uformowanym w kształcie kaczego dzioba. Szeroki otwór gębowy, szczęka dolna wysunięta do przodu.", Url = "img/szczupak.jpg" }
            }
            });

            galleries.Add(new Gallery
            {
                CatID = 1,
                SubCatID = 2,
                SubCat = "Morskie",
                SubCatUrl = "img/nefrytek.jpg",
                Photos = new ObservableCollection<Photo>() {
                    new Photo() { Name = "Nefrytek Królewski", Description = "Istnieje co najmniej kilka wariantów barwnych tego gatunku, które różnią się w zależności od miejsca występowania. Forma podstawowa jest żółto-szara lub żółto-niebieska (tułów). Obrys sylwetki z wyłączeniem płetwy ogonowej jest podkreślony kolorem turkusowym lub niebieskim.", Url = "img/nefrytek.jpg" },
                    new Photo() { Name = "Plataks Pospolity", Description = "Młode osobniki posiadają bardzo wydłużone płetwy - grzbietową i odbytową (prawie jak słodkowodny żaglowiec skalar), dorosłe osobniki kształtem przypominają słodkowodne dyskowce. Oba gatunki różnią się nieco ubarwieniem - jednak ich rozróżnianie bywa trudne, ponieważ istnieje kilka odmian barwnych każdego z gatunków, gdzie występują różnice w kolorystyce tułowia, umiejscowieniu i nasyceniu kolorem pasów na ciele.", Url = "img/plataks.jpg" },
                    new Photo() { Name = "Strzępiel Panterka", Description = "Występuje kilka odmian nieznacznie różniących się ubarwieniem, najbardziej znana jest forma śnieżnobiała z czarnymi okrągłymi kropkami lub biała z beżowymi przebarwieniami na tułowiu w czarne kropki, głowa jest mała w odniesieniu do reszty tułowia.", Url = "img/strzepiel.jpg" },
                    new Photo() { Name = "Korys Formosa", Description = "Ryba inaczej wygląda gdy jest młoda i zupełnie inaczej gdy jest dojrzała (inne jest zarówno ubarwienie jak i kształt). Dorosłe osobniki są jasne (białawe, szarawe lub błękitne) w czarne plamki, płetwy posiadają częściowo czerwone ubarwienie, głowa jaśniejsza od tułowia.", Url = "img/korys.jpg" },
                    new Photo() { Name = "Garbik Tylnopasy", Description = "Ciało jasne - jasnobeżowe, kremowe lub jasno brudno-żółte (młode osobniki głównie w kolorze cytrynowym), głowa z góry nieco przyciemniona, z tyłu tułowia u nasady płetwy ogonowej czarny pionowy pas, płetwa ogonowa biaława, u dorosłych osobników posiada nitkowate wyrostki.", Url = "img/garbik.jpg" }
            }
            });

            galleries.Add(new Gallery
            {
                CatID = 1,
                SubCatID = 3,
                SubCat = "Akwariowe",
                SubCatUrl = "img/zagrzebka.jpg",
                Photos = new ObservableCollection<Photo>() {
                    new Photo() { Name = "Zagrzebka Rachowa", Description = "Należy do grupy ryb potocznie nazywanych „Killifish”. Pochodzenie tej nazwy nie jest do końca jasne, prawdopodobnie wywodzi się od germańskiego słowa „kill”, które w staro nordyckiej formie oznaczało zatokę lub w niderlandzkiej koryto rzeki albo kanał wodny. Prawdopodobnie ma to związek, z tym że ryby te żyją w małych, wydzielonych zbiornikach wodnych, które okresowo wysychają.", Url = "img/zagrzebka.jpg" },
                    new Photo() { Name = "Danio Tęczowy", Description = "Często niedoceniany i pomijany przez wielu akwarystów. W sklepach akwarystycznych, trzymany w jasnych i nieurządzonych zbiornikach, wydaje się mało atrakcyjny. Osobniki zdrowe, w dobrej kondycji, trzymane w odpowiednich warunkach, często ukazują pełną paletę różnorodnych mieniących barw.", Url = "img/danio.jpg" },
                    new Photo() { Name = "Babka Tęczowa", Description = "Ryby te potrafią w pewnym zakresie obracać głową. Niestety ze względu na ich specjalne wymagania żywieniowe i duże zapotrzebowanie na tlen, w sprzedaży często są dostępne wychudzone, zaniedbane osobniki, które mogą być trudne do odratowania.", Url = "img/babka.jpg" },
                    new Photo() { Name = "Bocja Kubotai", Description = "Rodzaj ryby akwariowej z rodziny Botiidae. Wcześniej umieszczony w rodzinie piskorzowatych. Dopiero w 2004 r. rodzaj Botia został zmieniony i sklasyfikowany w obecnym rodzaju. Gatunek został opisany dosyć niedawno i szybko zdobył popularność wśród akwarystów. W 2002 r. kolekcjonerzy ryb pracujący w zachodniej Tajlandii rozszerzyli obszar swoich poszukiwań na teren Mjanmy (Birmy), gdzie między innymi odkryli ten gatunek.", Url = "img/bocja.jpg" },
                    new Photo() { Name = "Żaglowiec Wysoki", Description = "Rzadko dostępny i najbardziej pożądany przez wielbicieli pielęgnic, co ma niestety przełożenie na jego cenę, która odzwierciedla jego wyjątkowość.", Url = "img/zaglowiec.jpg" }
            }
            });

            galleries.Add(new Gallery
            {
                CatID = 1,
                SubCatID = 4,
                SubCat = "Drapieżne",
                SubCatUrl = "img/pstrag.jpg",
                Photos = new ObservableCollection<Photo>() {
                    new Photo() { Name = "Lipień", Description = "Lipień ma lekko spłaszczone ciało i małą głowę. Otwór gębowy jest niewielki, z drobnymi zębami, szczęka górna jest nieco dłuższa od dolnej i wysunięta do przodu. Lipień posiada charakterystyczne duże łuski, mocno osadzone w skórze. Lipień zwraca uwagę oryginalnym ubarwieniem – u młodych osobników jest ono srebrzysto-jasnozielone z niebieskawymi plamami na bokach, starsze osobniki wyróżniają się szarozielonym grzbietem, zielonkawymi bokami i białym brzuchem, który w okresie tarła przybiera purpurowy odblask. ", Url = "img/lipien.jpg" },
                    new Photo() { Name = "Pstrąg Potokowy", Description = "Pstrąg to zdecydowanie ryba górska, oba jego gatunki żyją w rzekach górskich oraz górnych odcinkach rzek średnich nizinnych. W Polsce najczęściej można je spotkać w południowej i północnej części kraju, wodach: Beskidów, Tatr, Sudetów, Dolnego Śląska, Rudawy, Przemszy, Jury Krakowsko-Częstochowskiej oraz Pomorza Zachodniego i Środkowego, Warmi i Mazur. ", Url = "img/pstrag.jpg" },
                    new Photo() { Name = "Łosoś", Description = "Łosoś ma ciało wydłużone o smukłym trzonie ogonowym ze stosunkowo małą, spiczastą głową i szerokim wycięciem gębowym, sięgającym tylnej krawędzi oka. Dorosłe osobniki posiadają nieregularne, czarne plamy na górnej połowie ciała. Boki są szarosrebrzyste.", Url = "img/losos.jpg" },
                    new Photo() { Name = "Dorsz", Description = "Dorsz jest gatunkiem wędrownym, którego można spotkać w północnej części Oceanu Atlantyckiego, od północnej Finlandii do północnej Karoliny, na wschodzie od Spitsbergenu do Zatoki Biskajskiej. W północnej Europie tereny dorsza to m.in. Morze Bałtyckie.", Url = "img/dorsz.jpg" },
                    new Photo() { Name = "Sandacz", Description = "Sandacze ryby wyróżniają się zdecydowanie wydłużonym ciałem i małą głową, grzbiet ma zielono-szary kolor, a brzuch jest biały. Jedyną wspólną z popularnym garbusem cechą sandacza, są ciemne, poprzeczne smugi, które występują u tej ryby na bokach ciała. Sandacz wyróżnia się także dwiema stykającymi się ze sobą płetwami grzbietowymi, które rzadko są od siebie oddalone.", Url = "img/sandacz.jpg" }
            }
            });

            galleries.Add(new Gallery
            {
                CatID = 1,
                SubCatID = 5,
                SubCat = "Białe",
                SubCatUrl = "img/karp.jpg",
                Photos = new ObservableCollection<Photo>() {
                    new Photo() { Name = "Karp", Description = "Karpie ryby posiadają wydłużone ciało, bardzo lekko bocznie ścieśnione, linia boczna jest słabo zaznaczona; głowa duża z wysuwaną paszczą wyposażona w cztery małe, krótkie wąsiki. Karp przybiera ciemnobrunatne i żółtobrunatne barwy w zależności od warunków środowiskowych. Otwór gębowy z dwoma małymi wąsikami przy górnej wardze oraz dwoma mniejszymi w kącikach warg.", Url = "img/karp.jpg" },
                    new Photo() { Name = "Amur", Description = "Ryby swoim wydłużonym, wrzecionowatym, bocznie spłaszczonym ciałem przypominają klenia. Linia boczna przebiega wyraźnie lekkim łukiem od płetwy ogonowej do górnej krawędzi wieczka skrzelowego. Głowa jest dość duża z tępym pyskiem i półdolnym otworem gębowym pozbawionym wąsów.", Url = "img/amur.jpg" },
                    new Photo() { Name = "Płoć", Description = "Płoć ma ciało mniej lub bardziej wygrzbiecone i ścieśnione w płaszczyznach bocznych. Brzuch jest lekko zaokrąglony na odcinku pomiędzy płetwami brzusznymi, a płetwą odbytową. Najbardziej charakterystycznym znakiem jeśli chodzi o płoć są czerwonawe oczy.", Url = "img/ploc.jpg" },
                    new Photo() { Name = "Jaź", Description = "Jaź posiada wydłużone i spłaszczone bocznie ciało, linia boczna jest lekko wygięta ku dołowi, płetwa ogonowa głęboko wcięta, głowa mała z wysuwaną paszczą skierowaną ukośnie ku górze. Grzbiet ma kolor szarozielony do szaroczarnego. Boki są jaśniejsze o intensywnym srebrzystym połysku, a brzuch białawy.", Url = "img/jaz.jpg" },
                    new Photo() { Name = "Lin", Description = "Mają ciało pokryte drobnymi łuskami jest zwarte i mocno zbudowane o szerokim trzonie ogonowym. Otwór gębowy jest poziomy, a w jego kącikach znajduje się po jednym krótkim i miękkim wąsiku. Grzbiet ma najczęściej ma kolor ciemnozielony lub ciemnobrązowy, boki są jaśniejsze i mosiężnie połyskujące, natomiast strona brzuszna żółtawobiała.", Url = "img/lin.jpg" }
            }
            });

            galleries.Add(new Gallery
            {
                CatID = 2,
                SubCatID = 1,
                SubCat = "Duże",
                SubCatUrl = "img/bocian.jpg",
                Photos = new ObservableCollection<Photo>() {
                    new Photo() { Name = "Bocian Biały", Description = "Według dawnych opowieści pewien człowiek zamiast wyrzucić do morza zebrane przez Boga nadmiernie rozmnożone gady, płazy, gryzonie i wszelkie owady, przypadkiem wypuścił je z powrotem. Za karę, zamieniony w Bociana, ma posprzątać z nich świat.", Url = "img/bocian.jpg" },
                    new Photo() { Name = "Czapla Siwa", Description = "Czapla to duży ptak brodzący, nieco mniejszy od Bociana czy Żurawia. Ma szary grzbiet i szare skrzydła z niebieskawym nalotem, szczególnie intensywnym w okresie godowym, czarne lotki i pokrywy pierwszego rzędu oraz szarobiały spód ciała. Prosty, masywny, sztyletowaty dziób jest szarożółty, a w okresie godowym przybiera odcień pomarańczowy. ", Url = "img/czapla.jpg" },
                    new Photo() { Name = "Puchacz", Description = "Nietrudno go odróżnić od pozostałych polskich sów, ponieważ odznacza się wielkością i charakterystyczną, „baryłkowatą” sylwetką. Wrażenie masywności wzmacnia gęste,  puszyste upierzenie i duża głowa. Samice są wyraźnie większe od samców. Upierzenie obu płci to przykład kamuflażu doskonałego. Kombinacja brązów, beży i szarości, pokrytych ciemnymi kreskami i plamkami sprawia, że ptaka nie łatwo wypatrzeć w leśnym gąszczu.", Url = "img/puchacz.jpg" },
                    new Photo() { Name = "Sowa Śnieżna", Description = "Sowa śnieżna to jeden z najokazalszych gatunków sów, wielkością dorównuje Puchaczowi. Jest  ptakiem drapieżnym o przeszywającym spojrzeniu, intensywnie żółtych oczu. Posiada charakterystyczną szlarę, a wokół dzioba długie, pióra czuciowe. Dzięki mocno opierzonym nogom i stopom może poruszać się po śniegu niemal nie zostawiając tropów.", Url = "img/sowas.jpg" }
            }
            });

            galleries.Add(new Gallery
            {
                CatID = 2,
                SubCatID = 2,
                SubCat = "Małe",
                SubCatUrl = "img/bogatka.jpg",
                Photos = new ObservableCollection<Photo>() {
                    new Photo() { Name = "Bogatka", Description = "Te pełne życia ptaki zadają szyku czy to w lesie, czy w karmniku. A to za sprawą czarnego, mocno zarysowanego krawatu, który biegnie przez środek intensywnie żółtej piersi i brzuszek – aż po sam ogon. U samczyków jest on zwykle szerszy niż u samiczek. Eleganckim dodatkiem jest czarna – lśniąca u panów, a matowa u pań – czapeczka, która pięknie kontrastuje z białymi policzkami. Plecy i skrzydła są żółtozielone z niebieskimi dodatkami.", Url = "img/bogatka.jpg" },
                    new Photo() { Name = "Drozd Śpiewak", Description = "Drozd Śpiewak to ptak o krępej budowie, wielkości szpaka. Grzbiet ma w ciepłych odcieniach szarości i brązów, a pierś jasnokremową, gęsto nakrapianą ciemnymi plamkami. Głowę zdobią duże, ciemne oczy. Z oczu i sylwetki przypomina kosa lub kwiczoła, co nie powinno dziwić, gdyż wszystkie należą do rodziny drozdowatych. Cechuje je bardzo dobre widzenie w ciemności oraz podobne środowisko i tryb życia. Śpiewak w porównaniu z innymi drozdami odznacza się krótkim ogonem.", Url = "img/drozd.jpg" },
                    new Photo() { Name = "Jerzyk", Description = "Większy od jaskółek, z długimi, sierpowatymi skrzydłami o rozpiętości do 44 cm, ze słabo rozwidlonym, krótkim ogonem i z bardzo krótkimi nogami, których wszystkie palce skierowane są do przodu. Lata w stadach, niezwykle szybko, naprzemiennie ślizgami lub płytko, poruszając skrzydłami. Cały w kolorze brunatnym, z delikatnym połyskiem i jaśniejszym, białawym gardłem. Młode są podobne do dorosłych, z jaśniejszym podbródkiem i białym czołem.", Url = "img/jerzyk.jpg" },
                    new Photo() { Name = "Wróbel Zwyczajny", Description = "Ruchliwe, gadatliwe i bardzo towarzyskie, Wróble potrafią funkcjonować tylko w grupie. Im większa wróblowa społeczność, tym lepiej. Całymi godzinami sejmikują w kępach krzewów lub w gęstych koronach niskich drzew. Wspólnie jedzą, kąpią się – w piachu lub w wodzie – i nocują. Ich charakterystyczne, znane chyba wszystkim, ćwierkanie to rozbudowane kody komunikacyjne.", Url = "img/wrobel.jpg" }
            }
            });

            galleries.Add(new Gallery
            {
                CatID = 2,
                SubCatID = 3,
                SubCat = "Średnie",
                SubCatUrl = "img/bazant.jpg",
                Photos = new ObservableCollection<Photo>() {
                    new Photo() { Name = "Bażant", Description = "Bażant to ptak ekstrawagancki. Do tego stopnia, że dawniej nazywanie kogoś bażantem ze względu na niepospolite cechy charakteru lub wyglądu nie musiało oznaczać komplementu. Słowo „bażant” stało się także określeniem rarytasów kulinarnych. Zjawiskowość tego ptaka nie pozostawia wątpliwości, dlaczego.", Url = "img/bazant.jpg" },
                    new Photo() { Name = "Czajka", Description = "Czajki są wielkości gołębi, ale mają znacznie dłuższe, czerwone nogi. Wierzch ciała ma kolor czarny z zielonym połyskiem, skrzydła są czarne z połyskiem purpurowym, a pierś, brzuch oraz boki głowy – białe. Długie pióra na czarnej z wierzchu głowie tworzą charakterystyczny sterczący do góry czubek, nieco dłuższy u samca (8–10 cm) niż u samicy (5–7 cm). Pokrywy podogonowe są rdzawe, ogon biały, zaokrąglony, z czarną plamą na końcu.", Url = "img/czajka.jpg" },
                    new Photo() { Name = "Dzięcioł Średni", Description = "Obie płcie ubarwione są tak samo, przy czym barwy samca są intensywniejsze, a czapeczka zachodzi głębiej na tył głowy. Młode ptaki swoją szatę mają bardziej matową a na czapeczce widoczne są czarne plamki. Dzięcioł Średni siedząc w poprzek gałęzi opuszcza ogon a jego sylwetka jest wtedy lekko przygarbiona. Zwykle lata niewysoko, a jego lot jest lekki i falisty.", Url = "img/dzieciol.jpg" },
                    new Photo() { Name = "Gołąb Miejski", Description = "Gołębie miejskie, które znamy z naszych osiedli, parkowych alejek i ulic to potomkowie hodowlanych gołębi domowych, które z różnych przyczyn nie wróciły do swoich gołębników i zaczęły prowadzić życie na wpół dzikie. Dzięki takiemu pochodzeniu gołębie te mają różne geny odpowiedzialne za charakterystyczny wygląd, niespotykany u ich dzikich przodków – gołębi skalnych – m.in. różnorodny kolor upierzenia lub pióra na nogach.", Url = "img/golab.jpg" },
                    new Photo() { Name = "Sójka", Description = "Sójka to nasz najbarwniejszy przedstawiciel krukowatych. Od swoich pobratymców, u których dominuje kolor czarny, odróżnia się rdzawobrązowymi tonacjami, często w różowopastelowych odcieniach, które mocno kontrastują z czarnymi i białymi elementami. Na głowie Sójka ma nakrapianą „czapeczkę”, którą zaniepokojona zabawnie stroszy.", Url = "img/sojka.jpg" }
            }
            });

            galleries.Add(new Gallery
            {
                CatID = 3,
                SubCatID = 1,
                SubCat = "Ważki",
                SubCatUrl = "img/husarz.jpg",
                Photos = new ObservableCollection<Photo>() {
                    new Photo() { Name = "Husarz Ciemny", Description = "Gatunek ważki z rodziny żagnicowatych. Samiec od samicy rożni się tylko nieznacznie. Odwłok oraz tułów jest brązowoszary lub brązowofioletowy. U samców drugi segment i fragment trzeciego segmentu są niebieskie. Przed nimi znajduje się jeden żółtawy pasek. Skrzydła mają brązowy kolor na środku.", Url = "img/husarz.jpg" },
                    new Photo() { Name = "Żagiew Ruda", Description = "Ma jaskrawozielone oczy. Na drugim członie odwłoka jest widoczna żółta plama. Ubarwienie rudawe. Występuje w Europie i w Afryce północnej. W Polsce spotykana jest na nizinach w trzcinowiskach starych rzek, starorzeczy, rowów i strumieni.", Url = "img/zagiew.jpg" },
                    new Photo() { Name = "Szablak Czarny", Description = "Ważka z rodziny ważkowatych. Ubarwienie samców prawie w całości czarne, poza żółtymi paskami na bokach tułowia. Samica jest żółtobrązowa z czarnymi paskami na tułowiu i czarnymi paskami na spodzie odwłoka. Młode samce nie są czarne. Są nieco podobne do samic.", Url = "img/szablak.jpg" },
                    new Photo() { Name = "Ważka Czteroplama", Description = "Ubarwienie samca i samicy brązowe. Odwłok jest lekko spłaszczony i ciemniejszy na końcu. Na skrzydłach znajdują się czarne znamiona skrzydłowe i ciemna plama na węzełku. U nasady skrzydeł drugiej pary znajduje się czarna, dość duża plama.", Url = "img/czteroplama.jpg" },
                    new Photo() { Name = "Zalotka Większa", Description = "Młode samce są brązowe, mają na wierzchniej stronie odwłoka żółty rysunek złożony z 2-7 plam. Poza tylną plamą plamy pozostałe szybko stają się brązowe. Dojrzałe osobniki męskie mają na 7. segmencie odwłoka żółtą, jaskrawą plamę. Samice są silniej zbudowane. One mają na odwłoku także żółte plamy. U nasady skrzydeł samca i samicy występuje ciemna plama.", Url = "img/zalotka.jpg" }
            }
            });

            galleries.Add(new Gallery
            {
                CatID = 3,
                SubCatID = 2,
                SubCat = "Motyle",
                SubCatUrl = "img/karlatek.jpg",
                Photos = new ObservableCollection<Photo>() {
                    new Photo() { Name = "Karłątek Akteon", Description = "Gatunek motyla z rodziny karłątkowatych. Skrzydła ciemnopomarańczowe z oliwkowym odcieniem. U samicy widoczna delikatna, niepełna żółtawa przepaska. Od spodu skrzydła są jaśniejsze. Gatunek ten występuje w Europie, Azji i Afryce. W Polsce od centralnej części kraju na południe, ale poza obszarami górzystymi. Można go spotkać na skrajach lasów, w kamieniołomach, żwirowniach, łąkach i terenach ruderalnych.", Url = "img/karlatek.jpg" },
                    new Photo() { Name = "Powszelatek Brunatek", Description = "Gatunek motyla z rodziny powszelatkowatych, to nasz najbardziej pospolity powszelatek. Skrzydła z wierzchu są brunatne z ciemnymi przepaskami. Przy brzegu skrzydeł widoczne białe drobne plamki. Skrzydła od spodu są również brunatne.", Url = "img/powszelatek.jpg" },
                    new Photo() { Name = "Koszówka Murzynka", Description = "Gatunek motyla z rodziny koszówkowatych. Samica ma skrzydła zredukowane i zredukowane odnóża. Samiec ma ciemne skrzydła. Gąsienica samca buduje koszyczek z suchych liści i źdźbła trawy. Gąsienica samicy buduje mniejszy koszyczek.", Url = "img/murzynka.jpg" }
            }
            });

            galleries.Add(new Gallery
            {
                CatID = 3,
                SubCatID = 3,
                SubCat = "Błonówki",
                SubCatUrl = "img/miodna.jpg",
                Photos = new ObservableCollection<Photo>() {
                    new Photo() { Name = "Pszczoła Miodna", Description = "Najbardziej znany przedstawiciel pszczołowatych zaliczany do podrodziny pszczół (Apinae) o ogromnym znaczeniu gospodarczym dla człowieka. Ubarwienie ciała jest brązowe. Pierwsze segmenty odwłoka nierzadko mają żółty lub czerwonawy kolor. Od grzbietowej strony odwłoka występują ciemne przepaski. Królowa ma wydłużony odwłok, trutnie mają większe oczy.", Url = "img/miodna.jpg" },
                    new Photo() { Name = "Smuklik Sześciopasy", Description = "Gatunek błonkówki z rodziny pszczołowatych o smukłej sylwetce ciała. Na piątym segmencie odwłoka u samców widoczna biała przepaska. Preferuje tereny otwarte, o piaszczystej i gliniastej ziemi. U nas nieliczny.", Url = "img/smuklik.jpg" },
                    new Photo() { Name = "Trzmiel Gajowy", Description = "Bardzo podobny do trzmiela ziemnego owad z rodziny pszczołowatych o krępej budowie ciała, pokryty gęsto włosiem. Na ciele występują żółte i białawe paski. W odróżnieniu od trzmiela ziemnego ma cytrynowożółtą przepaskę, która kończy się u nasady skrzydeł. Czułki cienkie, nitkowate.", Url = "img/trzmiel.jpg" },
                    new Photo() { Name = "Zadrzechnia Fioletowa", Description = "Gatunek błonkówki z rodziny pszczołowatych, jedna z największych naszych pszczół. Ubarwienie jednolicie czarne, skrzydła ciemne z fioletowym odcieniem. Czułki samca są na końcu żółtobrązowe, odgięte.", Url = "img/fioletowa.jpg" }
            }
            });

            galleries.Add(new Gallery
            {
                CatID = 3,
                SubCatID = 4,
                SubCat = "Móchówki",
                SubCatUrl = "img/mucha.jpg",
                Photos = new ObservableCollection<Photo>() {
                    new Photo() { Name = "Mucha Domowa", Description = "Jedna z najbardziej znanych muchówek. Głowa jest czarna, oczy są bardzo duże, mają złożoną budowę i są czerwonawe. Czułki są bardzo krótkie, ich trzeci człon jest trzy razy dłuższy od drugiego, znajduje się na nim pierzasta struktura. Aparat gębowy jest typu liżącego. Całe ciało jest ciemnoszare, odwłok żółto-brązowy, skrzydła błoniaste, przeźroczyste, z wyraźnym żyłkowaniem.", Url = "img/mucha.jpg" },
                    new Photo() { Name = "Bzyg Brzęk", Description = "Gatunek muchówki z rodziny bzygowatych. Odwłok ma czarny kolor z białawymi przepaskami, przerwanymi na środku. Pierwsza przepaska jest prosta i występuje na drugim segmencie odwłoka. Pozostałe dwie przepaski są zakrzywione ku górze. ", Url = "img/bzyg.jpg" },
                    new Photo() { Name = "Gnojka Trutniowata", Description = "Pospolita w Polsce muchówka z rodziny bzygowatych o dość dużych rozmiarach, pękatym ciele. Tułów jest szeroki, szarobrązowy, pokryty częściowo włoskami. Odwłok czarny z brązowawymi pasami. Muchówka ta przypomina bardzo pszczołę. Oczy są duże, ciemnobrązowe.", Url = "img/gnojka.jpg" },
                    new Photo() { Name = "Trzmielówka Łąkowa", Description = "Muchówka z rodziny bzygowatych, która do złudzenia przypomina trzmiela. Zamieszkuje łąki na skrajach lasów, polany.", Url = "img/trzmielowka.jpg" }
            }
            });

            galleries.Add(new Gallery
            {
                CatID = 3,
                SubCatID = 5,
                SubCat = "Chrząszcze",
                SubCatUrl = "img/majowy.jpg",
                Photos = new ObservableCollection<Photo>() {
                    new Photo() { Name = "Chrabąszcz Majowy", Description = "Pospolity chrząszcz w Polsce. Ma czarne przedplecze, brązowe pokrywy skrzydłowe. Po bokach ciała znajdują się jasne trójkąty. Odwłok wydłużony, zakończony cienkim wyrostkiem. Samiec ma duże, wachlarzowate czułki, złożone z siedmiu blaszek, samica (na zdjęciu) ma czułki złożone z sześciu blaszek.", Url = "img/majowy.jpg" },
                    new Photo() { Name = "Ogrodnica Niszczylistka", Description = "Ma czarne, gęsto owłosione ciało, brązowe (rude) pokrywy skrzydłowe (czasami pokrywy są czarne). Przedplecze ma zielonkawy, czarny lub niebieskawy, metaliczny połysk. Przedplecze ma węższe niż pokrywy skrzydłowe i jest najszersze pośrodku.", Url = "img/ogrodnica.jpg" },
                    new Photo() { Name = "Wałkarz Lipczyk", Description = "Przedstawiciel rodziny chrząszczowatych o krępej budowie ciała, małej głowie, dużym przedpleczu i odwłoku. Jest największym owadem z rodziny chrabąszczowatych w Polsce.", Url = "img/walkarz.jpg" }
            }
            });

            galleries.Add(new Gallery
            {
                CatID = 3,
                SubCatID = 6,
                SubCat = "Pluskwiaki",
                SubCatUrl = "img/kowal.jpg",
                Photos = new ObservableCollection<Photo>() {
                    new Photo() { Name = "Kowal Bezskrzydły", Description = "Pospolity w Polsce owad z rzędu pluskwiaków, o charakterystycznym, czerwonym zabarwieniu z czarnymi plamkami, żyjącym w dużych grupach. Można go zobaczyć w nasłonecznionych miejscach u podstawy pni drzew, płotów.", Url = "img/kowal.jpg" },
                    new Photo() { Name = "Pluskwa Domowa", Description = "Zewnętrzny pasożyt człowieka i ssaków domowych, żywiący się krwią. Ma szerokie ciało, mocno spłaszczone grzbietowo-brzusznie. Kolor ciała jest brązowawy. Czułki są nitkowate, głowa mała, z malutkimi oczami złożonymi.", Url = "img/pluskwa.jpg" },
                    new Photo() { Name = "Odorek Zieleniak", Description = "Pospolity, rodzimy, ubarwiony na zielono pluskwiak z rodziny tarczówkowatych. Brzegi odwłoka, oczy i czułki są czerwonawe. Koniec odwłoka jest brązowy. Larwy są całkowicie zielone, u niektórych przedplecze, śródplecze i środek odwłoka są czarne.", Url = "img/odorek.jpg" },
                    new Photo() { Name = "Strojnica Włoska", Description = "Bardzo łatwa do rozpoznania, ze względu na swe czarno-czerwone ubarwienie ciała, tarczówka. Z wierzchu ciało pokryte jest jaskrawymi pasami, od spodu pluskwiak ten jest czerwony w czarne kropki. Odnóża, czułki i małe oczy są czarne.", Url = "img/strojnica.jpg" },
                    new Photo() { Name = "Tarczówka Rudonoga", Description = "Gatunek pluskwiaka z rodziny tarczówkowatych. Przedplecze ma mocno uwypuklone boki. Ciało jest brązowe. Wierzchołek tarczki jest rudy. Rudo-czarne są też brzegi. Nogi są pomarańczowe.", Url = "img/tarczowka.jpg" }
            }
            });

            galleries.Add(new Gallery
            {
                CatID = 4,
                SubCatID = 1,
                SubCat = "Naczelne",
                SubCatUrl = "img/goryl.jpg",
                Photos = new ObservableCollection<Photo>() {
                    new Photo() { Name = "Goryl Nizinny", Description = "Naczelny ssak z rodziny człekokształtnych o dużych rozmiarach, żyjący w grupach rodzinnych liczących od 3 do 30 osobników w niedostępnych lasach tropikalnych. W każdej grupie dominuje samiec i ustanowiona jest hierarchia. Zadaniem młodych samców jest czuwanie nad bezpieczeństwem grupy.", Url = "img/goryl.jpg" },
                    new Photo() { Name = "Szympans", Description = "Najlepiej poznana małpa człekokształtna. Ręce dłuższe od nóg, nie posiada ogona. Ma długie palce u rąk i krótki kciuk. Twarz cętkowana. Biała skóra pokryta czarną sierścią. Młode osobniki mają białe włosy w okolicach odbytu. Jasne włosy u starszych osobników wysapują na brodzie.", Url = "img/szympans.jpg" },
                    new Photo() { Name = "Wyjec Czarny", Description = "Ssak naczelny z rodziny czepiakowatych z grupy małp szerokonosych. Samce są ubarwione na czarno, samice oraz młode osobniki żółtawe lub brązowe. Twarz nie jest owłosiona, ma czarną barwę.", Url = "img/wyjec.jpg" },
                    new Photo() { Name = "Czepiak Czarny", Description = "Gatunek małpy z rodziny czepiakowatych. Niektóre źródła zaliczają ten gatunek do specjalnie wyodrębnionej rodziny dla kilku gatunków - czepiakowatych (Atelidae). Małpa ta ma bardzo długie kończyny górne i dolne, a także długi i chwytny ogon.", Url = "img/czepiak.jpg" },
                    new Photo() { Name = "Galago Akacjowy", Description = "Gatunek ssaka z rodziny galagowatych. To niewielka małpiatka z dużymi oczami, odstającymi, zaokrąglonymi uszami, małym pyszczkiem. Ogon długi, cienki. Futerko szaro-płowe.", Url = "img/galago.jpg" }
            }
            });

            galleries.Add(new Gallery
            {
                CatID = 4,
                SubCatID = 2,
                SubCat = "Jeżokształtne",
                SubCatUrl = "img/jez.jpg",
                Photos = new ObservableCollection<Photo>() {
                    new Photo() { Name = "Jeż Wschodni", Description = "Pospolity ssak pokryty charakterystycznymi kolcami o długości od 2 do 3 cm. Ubarwienie ciała jest szarobrunatne. Na jeże polują lisy, tchórze, borsuki, psy, puchacze. Jeże są chronione. Są bardzo pożyteczne. Bywa, że są trzymane w pomieszczeniach ludzkich.", Url = "img/jez.jpg" },
                    new Photo() { Name = "Stepojeż Uszaty", Description = "Przedstawiciel owadożernych z rodziny jeżowatych, którego charakterystyczną cechą są duże małżowiny uszne (nawet 5 cm długości) i małe rozmiary ciała. Kolce mają charakterystyczny, piaskowy kolor.", Url = "img/stepojez.jpg" },
                    new Photo() { Name = "Jeż Zachodni", Description = "Gatunek owadożernego ssaka z rodziny jeżowatych. To nasz największy jeż. Z wierzchu ciało jeża pokryte jest kolcami. Ich ubarwienie jest żółtawe z ciemną przepaską mniej więcej w środku. Spód ciała jest żółty lub brązowy.", Url = "img/zachodni.jpg" }
            }
            });

            galleries.Add(new Gallery
            {
                CatID = 4,
                SubCatID = 3,
                SubCat = "Gryzonie",
                SubCatUrl = "img/myszl.jpg",
                Photos = new ObservableCollection<Photo>() {
                    new Photo() { Name = "Myszarka Leśna", Description = "Dawniej mysz leśna, to ssak z rodziny myszowatych. Ciało dorosłej myszy leśnej jest pokryte rudo-brunatnym futerkiem z wierzchu i boków, spód jest biały. Na piersi widoczna żółta plamka. Młode mają sierść szarą. charakterystyczne są dość duże oczy. Czasem wyrządza szkody w szkółkach leśnych.", Url = "img/myszl.jpg" },
                    new Photo() { Name = "Szczur Śniady", Description = "Gryzoń z rodziny myszowatych o zmiennym ubarwieniu. Wierzch czarny, spód jasny, warstwy te wyraźnie oddzielone. W odróżnieniu od szczura wędrownego jest nieco mniejszy, ma dłuższy ogon, większe uszy i bardziej wydłużony pysk. Jest tępionym szkodnikiem.", Url = "img/szczur.jpg" },
                    new Photo() { Name = "Mysz Domowa", Description = "Mały gryzoń z rodziny myszowatych. Futerko szare z żółtym odcieniem, od spodu zaś jest dużo jaśniejsze. Mysz ma długie wąsy. Jej pyszczek jest zaostrzony. Uszy są dość duże, zaokrąglone na końcach. Ogon prawie nieowłosiony, znajdują się na nim pierścieniowate łuski. Mysz domowa charakterystycznie pachnie.", Url = "img/myszd.jpg" },
                    new Photo() { Name = "Badylarka Pospolita", Description = "Niewielki ssak z rodziny myszowatych. Kolor sierści zwykle brunatny, spód jaśniejszy. Ma krótkie uszy. Samica ma 4 pary sutek. Potrafi wyrządzić spore szkody w uprawach.", Url = "img/badylarka.jpg" }
            }
            });

            galleries.Add(new Gallery
            {
                CatID = 4,
                SubCatID = 4,
                SubCat = "Drapieżne",
                SubCatUrl = "img/niedzwiedz.jpg",
                Photos = new ObservableCollection<Photo>() {
                    new Photo() { Name = "Niedźwiedź Brunatny", Description = "Chroniony ssak drapieżny z rodziny niedźwiedzi. Ma masywną budowę ciała, krótką i grubą szyję, małą głowę i oczy i uszy, bardzo silne kończyny. Skóra porośnięta bardzo gęstym futrem w kolorze brązowym, zdarzają się też okazy barwy kremowej i czarnej.", Url = "img/niedzwiedz.jpg" },
                    new Photo() { Name = "Niedźwiedź Czarny", Description = "Ssak z rodziny niedźwiedzi o jednolicie czarnym lub brązowym ubarwieniu sierści. Zdarza się również rude lub białe ubarwienie. Zamieszkuje Amerykę Północną, od Kanady po Meksyk.", Url = "img/niedzwiedzc.jpg" },
                    new Photo() { Name = "Lis Rudy", Description = "Średniej wielkości, często spotykany w Polsce drapieżnik o wydłużonym tułowiu i pysku, puszystym, pięknym ogonie, nazywanym kitą. Ma trójkątne, duże uszy. Ma długą sierść o barwie najczęściej żółtorudej, na spodzie białej lub popielatej.", Url = "img/lis.jpg" },
                    new Photo() { Name = "Wilk Szary", Description = "Największy przedstawiciel rodziny psów. Ma wydłużoną głowę, wąską klatkę piersiową, długie kończyny. Sierść ma płowy kolor z domieszką czarnych włosów, strona brzuszna jaśniejsza. Ma długie i grube kły. Ma największe łamacze ze wszystkich psów.", Url = "img/wilk.jpg" }
            }
            });

            galleries.Add(new Gallery
            {
                CatID = 4,
                SubCatID = 5,
                SubCat = "Walenie",
                SubCatUrl = "img/delfin.jpg",
                Photos = new ObservableCollection<Photo>() {
                    new Photo() { Name = "Delfin Zwyczajny", Description = "Najczęściej występujący w przyrodzie delfin. Przednia część pyska jest wyciągnięta w dziób. Na grzbiecie charakterystyczna płetwa w kształcie trójkąta z wierzchołkiem skierowanym ku tyłowi ciała.", Url = "img/delfin.jpg" },
                    new Photo() { Name = "Delfin Długopyski", Description = "Ssak morski z rodziny delfinowatych, często uznawany za podgatunek delfina zwyczajnego.", Url = "img/delfind.jpg" },
                    new Photo() { Name = "Waleń Biskajski", Description = "Ssak z rodziny wielorybów gładkoskórych. Samce są mniejsze od samic. Wal biskajski ma dużą głowę, zajmującą ćwierć długości całego ciała. Nie ma płetwy grzbietowej, a płetwy piersiowe są długie, mają aż 2 m długości.", Url = "img/walen.jpg" },
                    new Photo() { Name = "Waleń Południowy", Description = "Gatunek dużego ssaka morskiego z rodziny wielorybów gładkoskórych. Zasiedla morza i oceany na półkuli południowej w rejonach klimatu umiarkowanego i w wodach chłodnych, sięgając wybrzeża Antarktydy.", Url = "img/wal.jpg" }
            }
            });
        }
    }
}
