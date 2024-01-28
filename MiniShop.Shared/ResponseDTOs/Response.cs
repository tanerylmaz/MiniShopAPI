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


        /// <summary>
        /// Bu metot, işlemin başarılı oldugunu ifade eden bir status code döndürmek için kullanılır.
        /// </summary>
        /// <param name="statusCode">İşlemin sonucunu ifade eden kod</param>
        /// <returns>Response<typeparamref name="T"/></returns>
        public static Response<T> Success(int statusCode)
		{
			return new Response<T>
			{
				Data=default(T),
				StatusCode=statusCode,
				IsSucceeded=true
			};
		}
        /// <summary>
        /// Bu metot geriye başarısız bir cevap olarak hata listesini döndürmek için kullanılır
        /// </summary>
        /// <param name="errors">Hata listesi</param>
        /// <param name="statusCode">İşlem sonucu ifade eden kod</param>
        /// <returns>Response<typeparamref name="T"/></returns>
        public static Response<T> Fail(List<string> errors, int statusCode)
		{
			return new Response<T>
			{
				Errors=errors,
				StatusCode=statusCode,
				IsSucceeded=false
			};
		}
		/// <summary>
		/// Bu metot geriye başarısız bir cevap olarak içinde bir hata olan hata listesini döndürmek için kullanılır
		/// </summary>
		/// <param name="error">Hata metni</param>
		/// <param name="statusCode">İşlem sonucu ifade eden kod</param>
		/// <returns>Response<typeparamref name="T"/></returns>
        public static Response<T> Fail(string error, int statusCode)
        {
            return new Response<T>
            {
                Errors = new List<string> { error},
                StatusCode = statusCode,
                IsSucceeded = false
            };
        }
    }
}

