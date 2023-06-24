using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.World
{
	// Token: 0x020004DC RID: 1244
	[Token(Token = "0x20004DC")]
	public class GotoManager : MonoBehaviour
	{
		// Token: 0x060020A1 RID: 8353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A1")]
		[Address(RVA = "0x331B0E0", Offset = "0x33196E0", VA = "0x18331B0E0")]
		public static GotoManager.Location GetLocation(string id, StringComparison stringComparison = StringComparison.InvariantCultureIgnoreCase)
		{
			return null;
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x000098E8 File Offset: 0x00007AE8
		[Token(Token = "0x60020A2")]
		[Address(RVA = "0x331B2B0", Offset = "0x33198B0", VA = "0x18331B2B0")]
		private bool TryGet(string id, out GotoManager.Location result, StringComparison stringComparison = StringComparison.InvariantCultureIgnoreCase)
		{
			return default(bool);
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A3")]
		[Address(RVA = "0x331B4A0", Offset = "0x3319AA0", VA = "0x18331B4A0")]
		private void Awake()
		{
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A4")]
		[Address(RVA = "0x331B690", Offset = "0x3319C90", VA = "0x18331B690")]
		private void OnDestroy()
		{
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A5")]
		[Address(RVA = "0x331B780", Offset = "0x3319D80", VA = "0x18331B780")]
		public GotoManager()
		{
		}

		// Token: 0x04001E61 RID: 7777
		[Token(Token = "0x4001E61")]
		private const StringComparison DefaultStringComparison = StringComparison.InvariantCultureIgnoreCase;

		// Token: 0x04001E62 RID: 7778
		[Token(Token = "0x4001E62")]
		[FieldOffset(Offset = "0x0")]
		private static List<GotoManager> _managers;

		// Token: 0x04001E63 RID: 7779
		[Token(Token = "0x4001E63")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GotoManager.Location> _locations;

		// Token: 0x020004DD RID: 1245
		[Token(Token = "0x20004DD")]
		[Serializable]
		public class Location
		{
			// Token: 0x060020A7 RID: 8359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60020A7")]
			[Address(RVA = "0x331B930", Offset = "0x3319F30", VA = "0x18331B930")]
			public Location(string id, Transform source)
			{
			}

			// Token: 0x060020A8 RID: 8360 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60020A8")]
			[Address(RVA = "0x331BA70", Offset = "0x331A070", VA = "0x18331BA70")]
			public Location(string id, Vector3 position, Quaternion rotation)
			{
			}

			// Token: 0x060020A9 RID: 8361 RVA: 0x00009900 File Offset: 0x00007B00
			[Token(Token = "0x60020A9")]
			[Address(RVA = "0x331BAE0", Offset = "0x331A0E0", VA = "0x18331BAE0")]
			public bool Matches(string id, StringComparison stringComparison = StringComparison.InvariantCultureIgnoreCase)
			{
				return default(bool);
			}

			// Token: 0x04001E64 RID: 7780
			[Token(Token = "0x4001E64")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string _id;

			// Token: 0x04001E65 RID: 7781
			[Token(Token = "0x4001E65")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Vector3 _position;

			// Token: 0x04001E66 RID: 7782
			[Token(Token = "0x4001E66")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private Quaternion _rotation;
		}
	}
}
