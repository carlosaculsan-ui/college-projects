package Exception;

import  java. util.Scanner;


import java.time.LocalDate;

public class SaculsanCarlo {
    private static double balance = 150;
    private static final Scanner scanner = new Scanner(System.in);
    private static final LocalDate currentDate = LocalDate.now();

    public static void main(String[] args) {
        System.out.print("Dial USSD: ");
        String pin = scanner.nextLine();

        if (pin.equals("*143#")) {
            processUSSD();
        } else {
            System.out.println("Unable to contact USSD");
        }
    }

    private static void processUSSD() {
        System.out.println("Running USSD");
        ussdMenu("Globe");
    }
    private static void ussdMenu(String operator) {
        System.out.println("\nBAL " + balance + " " + currentDate);
        System.out.println("0. My Account");
        System.out.println("1.  Go+");
        System.out.println("2.  Go");
        System.out.println("3.  GoBOOSTERS");
        System.out.println("4.  Surf4All");
        System.out.println("5.  GoPREMIUM");
        System.out.println("6.  ALLNET");
        System.out.println("7.  All-Time Favorites");
        System.out.println("8.  GlobeONE");
        System.out.println("9. Rewards");
        System.out.println("10. Loans");
        System.out.println("11. Roaming & Int'l");
        System.out.print("\nEnter your choice: ");

        int choice = scanner.nextInt();
        scanner.nextLine();

        switch (choice) {
            case 0:
                Account();
                break;
            case 1:
                goPlus();
                break;
            case 2:
                go();
                break;
            case 3:
                goBoosters();
                break;
            case 4:
                surf4All();
                break;
            case 5:
                goPremium();
                break;
            case 6:
                allNet();
                break;
            case 7:
                allTime();
                break;
            case 8:
                globeOne();
                break;
            case 9:
                rewards();
                break;
            case 10:
                loans();
                break;
            case 11:
                roaming();
                break;
            default:
                System.out.println("Connection problem or invalid MMI code.");
        }

    }

    private static void Account() {
        System.out.println("1) Data Balance");
        System.out.println("2) SurfAlert");
        System.out.println("3) Just for me");
        System.out.println("4) Load Call Card");
        System.out.println("5) My Devices");
        System.out.println("6) Health & Wellness");
        System.out.println("7) Back");

        System.out.print("\nEnter your choice: ");

        int choice = scanner.nextInt();
        scanner.nextLine();

        switch (choice) {
            case 1:
                dataBalance();
                break;
            case 2:
                surfalert();
                break;
            case 3:
                just4me();
                break;
            case 4:
                loadcc();
                break;
            case 5:
                myDevices();
                break;
            case 6:
                health();
                break;
            case 7:
                ussdMenu("Globe");
                break;
            default:
                System.out.println("Connection problem or invalid MMI code.");
        }
    }

    private static void dataBalance() {
        System.out.println("Your balance is: " + balance);
    }

    private static void surfalert() {

        System.out.println("1) Turn ON mobile internet alerts");
        System.out.println("2) Check status");
        System.out.println("3) Back");
        System.out.println("4) Bookmark");

        System.out.print("\nEnter your choice: ");

        int choice = scanner.nextInt();
        scanner.nextLine();

        switch (choice) {
            case 1:
                System.out.println("Your mobile internet alerts is now open, enjoy surfing!");
                break;
            case 2:
                System.out.println("Your SurfAlert status is off");
                break;
            case 3:
                Account();
                break;
            case 4:
                System.out.println("You've just bookmarked this option, thank you!");
                break;
            default:
                System.out.println("Connection problem or invalid MMI code.");
        }
    }

    private static void just4me() {

        System.out.println("1) Back");

        System.out.print("\nEnter your choice: ");

        int choice = scanner.nextInt();
        scanner.nextLine();

        switch (choice) {
            case 1:
                Account();
                break;
            default:
                System.out.println("Connection problem or invalid MMI code.");
        }
    }

    private static void loadcc() {
        System.out.println(
                "You've registered you number to create a load call card, you will recieve a text message later.");
    }

    private static void myDevices() {
        System.out.println("1. Mobile Wifi/Myfi");
        System.out.println("2. Globe At Home");
        System.out.println("3. Back");

        System.out.print("\nEnter your choice: ");

        int choice = scanner.nextInt();
        scanner.nextLine();

        switch (choice) {
            case 1:
                System.out.println("Congratulations you are now registered to Wifi/Myfi!");
                break;
            case 2:
                System.out.println("Congratulations you have registered your (Broadband) to Home Prepaid Wifi");
                break;
            case 3:
                Account();
                break;
            default:
                System.out.println("Connection problem or invalid MMI code.");
        }
    }

    private static void health() {

        System.out
                .println("You are now subscribed to GoHealth for only P20.(charges may apply monthly to your balance)");
    }

    private static void goPlus() {
        System.out.println("1. Go+99");
        System.out.println("2. Go+129");
        System.out.println("3. Go+149");
        System.out.println("4. Go+250");
        System.out.println("5. Go+400");
        System.out.println("6. Back");

        System.out.print("\nEnter your choice: ");

        int choice = scanner.nextInt();
        scanner.nextLine();

        switch (choice) {
            case 1:
                go99();
                break;
            case 2:
                go129();
                break;
            case 3:
                go149();
                break;
            case 4:
                go250();
                break;
            case 5:
                go400();
                break;
            case 6:
                ussdMenu("Globe");
                break;
            default:
                System.out.println("Connection problem or invalid MMI code.");
        }
    }

    private static void go99() {
        System.out.println(
                "Enjoy 8GB data for all sites, 8GB choice of apps, 1 voucher of choice and unli allnet texts for 7 days for P99 only.");
    }

    private static void go129() {
        System.out.println(
                "Enjoy 10GB data for all sites, 8GB choice of apps, 1 voucher of choice, unli allnet texts and unli Globe/TM calls for 7 days. P129 only.");
    }

    private static void go149() {
        System.out.println(
                "Enjoy 12gb data for all sites, 8gb choice of apps, 1 voucher of choice, unli allnet calls & texts for 7 days. P149 only.");
    }

    private static void go250() {
        System.out.println(
                "Enjoy 15GB data for all sites, 15GB choice of apps, 1 voucher of choice. Valid for 15 days. P250 only.");
    }

    private static void go400() {
        System.out.println(
                "Enjoy 25GB data for all sites, 15GB choice of apps, 1 voucher of choice, Valid for 15 days. P400 only.");
    }

    private static void go() {
        System.out.println("1. Go59");
        System.out.println("2. Go75");
        System.out.println("3. Go+99");
        System.out.println("4. Go120");
        System.out.println("5. Go140");
        System.out.println("6. Go250");
        System.out.println("7. Go400");
        System.out.println("8. Back");

        System.out.print("\nEnter your choice: ");

        int choice = scanner.nextInt();
        scanner.nextLine();

        switch (choice) {
            case 1:
                go59();
                break;
            case 2:
                go75();
                break;
            case 3:
                goplus99();
                break;
            case 4:
                go120();
                break;
            case 5:
                go140();
                break;
            case 6:
                goreg250();
                break;
            case 7:
                goreg400();
                break;
            case 8:
                ussdMenu("Globe");
                break;
            default:
                System.out.println("Connection problem or invalid MMI code.");
        }
    }

    private static void go59() {
        System.out.println("Enjoy 5GB data for all sites and unli allnet texts for 3 days. P59 only.");
    }

    private static void go75() {
        System.out.println("Enjoy 5gb data for all sites, and unli allnet calls & texts for 3 days. P75 only.");
    }

    private static void goplus99() {
        System.out.println(
                "Enjoy 8GB data for all sites, 8GB choice of apps, 1 voucher of choice and unli allnet texts for 7 days for P99 only.");
    }

    private static void go120() {
        System.out.println(
                "Enjoy 10GB data for all sites, 10GB choice of apps, 1 voucher of choice and unli allnet texts for 7 days for P120 only.");
    }

    private static void go140() {
        System.out.println(
                "Enjoy 12GB data for all sites, 12GB choice of apps, 1 voucher of choice and unli allnet texts for 7 days for P140 only.");
    }

    private static void goreg250() {
        System.out.println(
                "Enjoy 20GB data for all sites, 15GB choice of apps, 1 voucher of choice and unli allnet texts for 7 days for P250 only.");
    }

    private static void goreg400() {
        System.out.println(
                "Enjoy 25GB data for all sites, 15GB choice of apps, 1 voucher of choice and unli allnet texts for 7 days for P400 only.");
    }

    private static void goBoosters() {
        System.out.println("\nAdd more with your Go promo by registering to any of the following GoBOOSTERS:");
        System.out.println("1. GoBOOST15");
        System.out.println("2. GoWATCH10");
        System.out.println("3. GoPLAY10");
        System.out.println("4. GoSHARE10");
        System.out.println("5. GoLEARN10");
        System.out.println("6. More");
        System.out.println("7. Back");

        System.out.print("\nEnter your choice: ");

        int choice = scanner.nextInt();
        scanner.nextLine();

        switch (choice) {
            case 1:
                boost15();
                break;
            case 2:
                watch10();
                break;
            case 3:
                play10();
                break;
            case 4:
                share10();
                break;
            case 5:
                learn10();
                break;
            case 6:
                more();
                break;
            case 7:
                ussdMenu("Globe");
                break;
            default:
                System.out.println("Connection problem or invalid MMI code.");
        }
    }

    private static void boost15() {
        System.out.println("Enjoy additional 1gb data for all sites for 1 day. P15 only.");
    }

    private static void watch10() {
        System.out.println(
                "Enjoy additional 1GB data for YouTube, Netflix, Viu, iWantTFC, and HBO Go for 1 day. P10 only.");
    }

    private static void play10() {
        System.out.println(
                "Enjoy additional 1GB daya for Mobile Legends, Pokemon Unite, Genshin Impact, PUBG, COD, League of Legends Wild Rift, and more for 1 day. P10 only.");
    }

    private static void share10() {
        System.out
                .println("Enjoy additional 1GB data for FB, IG, TikTok, Discord, Twitch and more for 1 day. P10 only.");
    }

    private static void learn10() {
        System.out.println(
                "Enjoy additional 1gb data for YouTube Learning, Udemy, Google Suite, Edukasyon and Canva for 1 day. P10 only.");
    }

    private static void more() {

        System.out.println("1. GoWORK10");
        System.out.println("2. GoSHOP10");
        System.out.println("3. GoLISTEN10");
        System.out.println("4. Back");

        System.out.print("\nEnter your choice: ");

        int choice = scanner.nextInt();
        scanner.nextLine();

        switch (choice) {
            case 1:
                System.out.println(
                        "Enjoy additional 1gb data for Zoom, FB Meeting Room, Yahoo! Mail, MS Teams, Whatsapp, Viber, and Telegram for 1 day. P10 only.");
                break;
            case 2:
                System.out.println(
                        "Enjoy additional 1gb data for Lazada, Shopee, ZALORA, BeautyMNL, Grab Food, and Foodpanda for 1 day. P10 only.");
                break;
            case 3:
                System.out.println(
                        "Enjoy additional 1gb data for YouTube Music, Spotify, SoundCloud and WeSing for 1 day. P10 only.");
                break;
            case 4:
                goBoosters();
                break;
            default:
                System.out.println("Connection problem or invalid MMI code.");
        }
    }

    private static void surf4All() {
        System.out.println("1. Surf4All 99");
        System.out.println("2. Surf4All 249");
        System.out.println("3. Status");
        System.out.println("4. Manage your group");
        System.out.println("5. Back");

        System.out.print("\nEnter your choice: ");

        int choice = scanner.nextInt();
        scanner.nextLine();

        switch (choice) {
            case 1:
                s4a99();
                break;
            case 2:
                s4a249();
                break;
            case 3:
                status();
                break;
            case 4:
                manage();
                break;
            case 5:
                ussdMenu("Globe");
                break;
            default:
                System.out.println("Connection problem or invalid MMI code.");
        }
    }

    private static void s4a99() {
        System.out.println("Enjoy 9gb all access and shareable data for all, valid for 7 days, P99.");
    }

    private static void s4a249() {
        System.out.println("Enjoy 20gb all access and shareable data for all, valid for 7 days, P249.");
    }

    private static void status() {
        System.out.println("You will recieve a text message shortly!");
    }

    private static void manage() {
        System.out.println("1. Add Member");
        System.out.println("2. Set Limit");
        System.out.println("3. Remove Member");
        System.out.println("4. Leave Group");

        System.out.print("\n Enter your choice: ");
        int choice = scanner.nextInt();

        switch (choice) {
            case 1:
                System.out.println("You will recieve a text message shortly!");
                break;
            case 2:
                System.out.println("You will recieve a text message shortly!");
                break;
            case 3:
                System.out.println("You will receive a text message shortly!");
                break;
            case 4:
                System.out.println("You have left the group");
                break;
            default:
                System.out.println("Connection problem or invalid MMI code.");
                break;
        }
    }

    private static void goPremium() {
        System.out.println("1. Disney+");
        System.out.println("2. Back");

        System.out.print("\nEnter your choice: ");

        int choice = scanner.nextInt();
        scanner.nextLine();

        switch (choice) {
            case 1:
                System.out.println("You are now subscribed to Disney+ for only 1499!");
                break;
            case 2:
                ussdMenu("Globe");
                break;
            default:
                System.out.println("Connection problem or invalid MMI code.");
        }
    }

    private static void allNet() {
        System.out.println(" The new GoUNLI now has calls & texts to ALL NETWORKS!");
        System.out.println("1. GoUNLI20");
        System.out.println("2. GoUNLI30");
        System.out.println("3.  GoUNLI50");
        System.out.println("4. GoUNLI95");
        System.out.println("5. GoUNLI180");
        System.out.println("6. GoUNLI350");
        System.out.println("7. Back");

        System.out.print("\nEnter your choice: ");

        int choice = scanner.nextInt();
        scanner.nextLine();

        switch (choice) {
            case 1:
                gO20();
                break;
            case 2:
                gO30();
                break;
            case 3:
                gO50();
                break;
            case 4:
                gO95();
                break;
            case 5:
                gO180();
                break;
            case 6:
                gO350();
                break;
            case 7:
                ussdMenu("Globe");
                break;
            default:
                System.out.println("Connection problem or invalid MMI code.");
        }
    }
    private static void gO20(){
        System.out.println("Enjoy Go Unli Data with:");
        System.out.println("-50 MB Data for all sites");
        System.out.println("-P20 Valid for 1 day");
    }
    private static void gO30(){
        System.out.println("Enjoy Go Unli Data with:");
        System.out.println("-100 MB Data for all sites");
        System.out.println("-P30 Valid for 2 day");
    }
    private static void gO50(){
        System.out.println("Enjoy Go Unli Data with:");
        System.out.println("-200MB Data for all sites");
        System.out.println("-P50 Valid for 3 day");
    }
    private static void gO95(){
        System.out.println("Enjoy Go Unli Data with:");
        System.out.println("-1GB Data for all sites");
        System.out.println("-P20 Valid for 7 day");
    }
    private static void gO180(){
        System.out.println("Enjoy Go Unli Data with:");
        System.out.println("- 2GB Data for all sites");
        System.out.println("-P180 Valid for 15 day");
    }
    private static void gO350(){
        System.out.println("Enjoy Go Unli Data with:");
        System.out.println("-3GB Data for all sites");
        System.out.println("-P350 Valid for 30 day");
    }
    private static void allTime() {
        System.out.println("1. Surfing");
        System.out.println("2. GoSAKTO");
        System.out.println("3.  Other Call & Text Promos");
        System.out.println("4. Back");

        System.out.print("\nEnter your choice: ");

        int choice = scanner.nextInt();
        scanner.nextLine();

        switch (choice) {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                ussdMenu("Globe");
                break;
            default:
                System.out.println("Connection problem or invalid MMI code.");
        }
    }

    private static void globeOne() {
        System.out.println("You will receive a text Message shortly.");
        ussdMenu("Globe");
    }

    private static void rewards() {
        System.out.println("1. Get New GlobeOne app");
        System.out.println("2. Check Globe Reward Points");
        System.out.println("3. Redeem Rewards");
        System.out.println("4. Paystore");
        System.out.println("5. Gifting");
        System.out.println("6. Get Program info");
        System.out.println("7. Back");
        System.out.print("\nEnter your choice: ");

        int choice = scanner.nextInt();
        scanner.nextLine();

        switch (choice) {
            case 1:
                System.out.println("You will recieve a text message shortly!");
                break;
            case 2:
                System.out.println("You will recieve a text message shortly");
                break;
            case 3:
                System.out.println("You will recieve a text message shortly");
                break;
            case 4:
                System.out.println("You will recieve a text message shortly");
                break;
            case 5:
                System.out.println("You will recieve a text message shortly");
                break;
            case 6:
                System.out.println("You will recieve a text message shortly");
                break;
            case 7:
                ussdMenu("Globe");
                break;
            default:
                System.out.println("Connection problem or invalid MMI code.");
        }
    }

    private static void loans() {
        System.out.println("Stay connected even without load, and pay later with our loan offers!");

        System.out.println("1. MBSOS/FOMOSOS");
        System.out.println("2. COMBOSOS");
        System.out.println("3. TXTSOS");
        System.out.println("4. CALLSOS");
        System.out.println("5. back");
        System.out.print("\nEnter your choice: ");

        int choice = scanner.nextInt();
        scanner.nextLine();

        switch (choice) {
            case 1:
                System.out.println("MBSOS or FOMOSOS lets you borrow 40MB for surfing valid for 1 day. Pay later by buying atleast P6 (P5 + P1 service fee) load.");
                break;
            case 2:
                System.out.println("COMBOSOS lets you borrow 2min calls and 2 texts to Globe/TM Valid for 1day. Pay later by buying at least P6 (P5 + P1 service fee) load.");
                break;
            case 3:
                System.out.println("TXTSOS lets you borrow 50mb texts and 30secs call to Globe/TM Valid for 1day. Pay later by buying at least P6 (P5 + P1 service fee) load.");
                break;
            case 4:
                System.out.println("CALLSOS lets you borrow 200mb for call to Globe/TM Valid for 1day. Pay later by buying at least P6 (P5 + P1 service fee) load.");
                break;
            case 5:
                ussdMenu("Globe");
                break;
            default:
                System.out.println("Connection problem or invalid MMI code.");
        }
    }

    private static void roaming() {
        System.out.println("1. Roaming");
        System.out.println("2. Call and Text Abroad");
        System.out.println("3.  Back");

        System.out.print("\nEnter your choice: ");

        int choice = scanner.nextInt();
        scanner.nextLine();

        switch (choice) {
            case 1:
                System.out.println("You're now on roam! just turn off your mobile phone upon arriva abroad to instantly connect to a roaming partner");
                break;
            case 2:
                System.out.println("You are now registered to Call & Text Abroad, Turn off your mobile data in order to access roaming partners");
                break;
            case 3:
                ussdMenu("Globe");
                break;
            default:
                System.out.println("Connection problem or invalid MMI code.");
        }
    }

}


































        
        
    

        





