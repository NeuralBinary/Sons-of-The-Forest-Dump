using System;
using Il2CppDummyDll;
using Sons.TerrainDetail;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200074B RID: 1867
	[Token(Token = "0x200074B")]
	[AddComponentMenu("Sons/Gameplay/BreakableFarLod")]
	public class BreakableFarLod : MonoBehaviour
	{
		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06003246 RID: 12870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000683")]
		public GameObject OriginalObject
		{
			[Token(Token = "0x6003246")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003247")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetOriginalObject(GameObject root)
		{
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003248")]
		[Address(RVA = "0x349B7F0", Offset = "0x3499DF0", VA = "0x18349B7F0")]
		private void TryGetWorldObjectLocatorHolder()
		{
		}

		// Token: 0x06003249 RID: 12873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003249")]
		[Address(RVA = "0x349BB50", Offset = "0x349A150", VA = "0x18349BB50")]
		private void OnValidate()
		{
		}

		// Token: 0x0600324A RID: 12874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600324A")]
		[Address(RVA = "0x349BB60", Offset = "0x349A160", VA = "0x18349BB60")]
		public void OnEnable()
		{
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600324B")]
		[Address(RVA = "0x349BB80", Offset = "0x349A180", VA = "0x18349BB80")]
		private void InitializeWorldObjectLocatorHolder()
		{
		}

		// Token: 0x0600324C RID: 12876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600324C")]
		[Address(RVA = "0x349BD60", Offset = "0x349A360", VA = "0x18349BD60")]
		public void OnDisable()
		{
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600324D")]
		[Address(RVA = "0x349BF40", Offset = "0x349A540", VA = "0x18349BF40")]
		private void OnWorldObjectLocatorStateChanged(WorldObjectState state, bool fromSave)
		{
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600324E")]
		[Address(RVA = "0x349BF50", Offset = "0x349A550", VA = "0x18349BF50")]
		private void OnBreak()
		{
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600324F")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public BreakableFarLod()
		{
		}

		// Token: 0x04002B5B RID: 11099
		[Token(Token = "0x4002B5B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _originalObject;

		// Token: 0x04002B5C RID: 11100
		[Token(Token = "0x4002B5C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WorldObjectLocatorHolder _worldObjectLocatorHolder;

		// Token: 0x04002B5D RID: 11101
		[Token(Token = "0x4002B5D")]
		[FieldOffset(Offset = "0x30")]
		private bool _isBroken;
	}
}
