using System;
namespace MiniShop.Shared.ResponseDTOs
{
	public class Response<T>
	{
		public T Data { get; set; }
		public List<string> Errors { get; set; }
		public int StatusCode { get; set; }
		public bool IsSucceeded { get; set; }

		/// <summary>
		/// Bu metot, yapılan işlemin başarılı oldugu durumlarda başarılı bir cevapla birlikte üretilen detayı ve status code u döndürmek için kullanılır.
		/// </summary>
		/// <param name="data">Geri döndürülecek veri</param>
		/// <param name="statusCode">İşlemin sonucunu ifade eden kod(200,201,...,299)</param>
		/// <returns>Response<typeparamref name="T"/></returns>
		public static Response<T> Success(T data, int statusCode)
		{
			return new Response<T>
			{
				Data=data,
				StatusCode=statusCode,
				IsSucceeded=true
			};
		}

		public static Response<T> Success(int statusCode)
		{
			return new Response<T>
			{
				Data=default(T),
				StatusCode=statusCode,
				IsSucceeded=true
			};
		}
	}
}

