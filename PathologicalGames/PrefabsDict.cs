using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	public class PrefabsDict : IDictionary<string, Transform>, ICollection<KeyValuePair<string, Transform>>, IEnumerable<KeyValuePair<string, Transform>>, IEnumerable
	{
		// Token: 0x06000135 RID: 309 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x28BFC50", Offset = "0x28BE250", VA = "0x1828BFC50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x28BFDF0", Offset = "0x28BE3F0", VA = "0x1828BFDF0")]
		internal void _Add(string prefabName, Transform prefab)
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x28BFE70", Offset = "0x28BE470", VA = "0x1828BFE70")]
		internal bool _Remove(string prefabName)
		{
			return default(bool);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x28BFED0", Offset = "0x28BE4D0", VA = "0x1828BFED0")]
		internal void _Clear()
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x17000040")]
		public int Count
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x28BFF20", Offset = "0x28BE520", VA = "0x1828BFF20", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x28BFF60", Offset = "0x28BE560", VA = "0x1828BFF60", Slot = "8")]
		public bool ContainsKey(string prefabName)
		{
			return default(bool);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x28BFFD0", Offset = "0x28BE5D0", VA = "0x1828BFFD0", Slot = "11")]
		public bool TryGetValue(string prefabName, out Transform prefab)
		{
			return default(bool);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x28C0040", Offset = "0x28BE640", VA = "0x1828C0040", Slot = "9")]
		public void Add(string key, Transform value)
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x28C0090", Offset = "0x28BE690", VA = "0x1828C0090", Slot = "10")]
		public bool Remove(string prefabName)
		{
			return default(bool);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x28C00E0", Offset = "0x28BE6E0", VA = "0x1828C00E0", Slot = "16")]
		public bool Contains(KeyValuePair<string, Transform> item)
		{
			return default(bool);
		}

		// Token: 0x17000041 RID: 65
		[Token(Token = "0x17000041")]
		public Transform this[string key]
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x28C0130", Offset = "0x28BE730", VA = "0x1828C0130", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x28C0210", Offset = "0x28BE810", VA = "0x1828C0210", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000042")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x28C0260", Offset = "0x28BE860", VA = "0x1828C0260", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000142 RID: 322 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000043")]
		public ICollection<Transform> Values
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x28C02B0", Offset = "0x28BE8B0", VA = "0x1828C02B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000143 RID: 323 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x17000044")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x17000045")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x28C0300", Offset = "0x28BE900", VA = "0x1828C0300", Slot = "14")]
		public void Add(KeyValuePair<string, Transform> item)
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x28C0350", Offset = "0x28BE950", VA = "0x1828C0350", Slot = "15")]
		public void Clear()
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x28C0390", Offset = "0x28BE990", VA = "0x1828C0390")]
		private void CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x28C03E0", Offset = "0x28BE9E0", VA = "0x1828C03E0", Slot = "17")]
		private void CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex)
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x28C0430", Offset = "0x28BEA30", VA = "0x1828C0430", Slot = "18")]
		public bool Remove(KeyValuePair<string, Transform> item)
		{
			return default(bool);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x28C0480", Offset = "0x28BEA80", VA = "0x1828C0480", Slot = "19")]
		public IEnumerator<KeyValuePair<string, Transform>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x28C0580", Offset = "0x28BEB80", VA = "0x1828C0580", Slot = "20")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x28C0680", Offset = "0x28BEC80", VA = "0x1828C0680")]
		public PrefabsDict()
		{
		}

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, Transform> _prefabs;
	}
}
