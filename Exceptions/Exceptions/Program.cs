
//bool isParse = true;

//try
//{
//	//string name = null;
//	//Console.WriteLine(name.ToString());

//	//int index = int.Parse(Console.ReadLine());

//	int[] arr = new int[2];
//	arr[0] = 5;

//	string? name = null;

//	if (name is null)
//	{
//        throw new NullReferenceException();
//    }

//	isParse = true;

//	Console.WriteLine(arr[0]);
//}
//catch (Exception ex)
//{
//	Console.WriteLine(ex.Message);
//	isParse = false;
//}
////catch (IndexOutOfRangeException ex)
////{
////    Console.WriteLine(ex.Message);
////}
////catch (ArgumentNullException ex)
////{
////    Console.WriteLine(ex.Message);
////}
//finally
//{
//	if (isParse)
//	{
//        Console.WriteLine("Welcome");
//    }
//	else
//	{
//		Console.WriteLine("Failed");
//	}
//}



//GetNameById(null);

//static void  GetNameById(int? id)
//{
//	try
//	{
//		if (id == null)
//		{
//			throw new ArgumentNullException();
//		}
//		else
//		{
//			Console.WriteLine("Name Id - " + id);
//		}
//	}
//	catch (Exception ex)
//	{
//		Console.WriteLine(ex.Message);
//	}
//}

using Exceptions.Controller;

AccountController account = new AccountController();

account.Register();