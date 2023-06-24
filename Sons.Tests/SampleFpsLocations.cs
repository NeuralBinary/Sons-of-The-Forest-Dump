using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Tests
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[CreateAssetMenu(menuName = "Sons/Testing/Sample Fps Locations", fileName = "SampleFpsLocations", order = 0)]
	public class SampleFpsLocations : ScriptableObject
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x314B290", Offset = "0x3149890", VA = "0x18314B290")]
		private void Import(string sourceString)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x314B340", Offset = "0x3149940", VA = "0x18314B340")]
		public bool TryImportFromPath(string path)
		{
			return default(bool);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public List<SampleFpsLocation> GetAll()
		{
			return null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public SampleFpsLocations()
		{
		}

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextAsset _sourceAsset;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<SampleFpsLocation> _locations;

		// Token: 0x02000012 RID: 18
		[Token(Token = "0x2000012")]
		[Serializable]
		internal class JsonConvertedLocations
		{
			// Token: 0x0600004D RID: 77 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public JsonConvertedLocations()
			{
			}

			// Token: 0x0400002D RID: 45
			[Token(Token = "0x400002D")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			internal List<SampleFpsLocation> _locations;
		}
	}
}
