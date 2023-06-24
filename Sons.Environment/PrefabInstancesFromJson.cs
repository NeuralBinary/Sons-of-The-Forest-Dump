using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public class PrefabInstancesFromJson : MonoBehaviour
	{
		// Token: 0x0600007C RID: 124 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2F9CF70", Offset = "0x2F9B570", VA = "0x182F9CF70")]
		private void ExtractData()
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetAsset(TextAsset asset)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PrefabInstancesFromJson()
		{
		}

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextAsset _greebleDataFile;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private JSONGreebleData _greebleData;
	}
}
