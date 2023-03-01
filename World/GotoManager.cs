using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.World
{
	// Token: 0x020004E6 RID: 1254
	[Token(Token = "0x20004E6")]
	public class GotoManager : MonoBehaviour
	{
		// Token: 0x0600202E RID: 8238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600202E")]
		[Address(RVA = "0x2D29CF0", Offset = "0x2D28CF0", VA = "0x182D29CF0")]
		public static GotoManager.Location GetLocation(string id, StringComparison stringComparison = 3)
		{
			return null;
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x00009570 File Offset: 0x00007770
		[Token(Token = "0x600202F")]
		[Address(RVA = "0x2D29F90", Offset = "0x2D28F90", VA = "0x182D29F90")]
		private bool TryGet(string id, out GotoManager.Location result, StringComparison stringComparison = 3)
		{
			return default(bool);
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002030")]
		[Address(RVA = "0x2D29B20", Offset = "0x2D28B20", VA = "0x182D29B20")]
		private void Awake()
		{
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002031")]
		[Address(RVA = "0x2D29EA0", Offset = "0x2D28EA0", VA = "0x182D29EA0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002032")]
		[Address(RVA = "0x2D2A1A0", Offset = "0x2D291A0", VA = "0x182D2A1A0")]
		public GotoManager()
		{
		}

		// Token: 0x04001E06 RID: 7686
		[Token(Token = "0x4001E06")]
		private const StringComparison DefaultStringComparison = 3;

		// Token: 0x04001E07 RID: 7687
		[Token(Token = "0x4001E07")]
		[FieldOffset(Offset = "0x0")]
		private static List<GotoManager> _managers;

		// Token: 0x04001E08 RID: 7688
		[Token(Token = "0x4001E08")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GotoManager.Location> _locations;

		// Token: 0x020004E7 RID: 1255
		[Token(Token = "0x20004E7")]
		[Serializable]
		public class Location
		{
			// Token: 0x06002034 RID: 8244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002034")]
			[Address(RVA = "0x2D2B500", Offset = "0x2D2A500", VA = "0x182D2B500")]
			public Location(string id, Transform source)
			{
			}

			// Token: 0x06002035 RID: 8245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002035")]
			[Address(RVA = "0x2D2B580", Offset = "0x2D2A580", VA = "0x182D2B580")]
			public Location(string id, Vector3 position, Quaternion rotation)
			{
			}

			// Token: 0x06002036 RID: 8246 RVA: 0x00009588 File Offset: 0x00007788
			[Token(Token = "0x6002036")]
			[Address(RVA = "0x2D2B4E0", Offset = "0x2D2A4E0", VA = "0x182D2B4E0")]
			public bool Matches(string id, StringComparison stringComparison = 3)
			{
				return default(bool);
			}

			// Token: 0x04001E09 RID: 7689
			[Token(Token = "0x4001E09")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string _id;

			// Token: 0x04001E0A RID: 7690
			[Token(Token = "0x4001E0A")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Vector3 _position;

			// Token: 0x04001E0B RID: 7691
			[Token(Token = "0x4001E0B")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private Quaternion _rotation;
		}
	}
}
