using System;
using System.Collections.Generic;
using Endnight.Utilities;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.World
{
	// Token: 0x020004DE RID: 1246
	[Token(Token = "0x20004DE")]
	[AddComponentMenu("Sons/Word/Directional Trigger (Link Activate)")]
	public class LinkActivateDirectionalTrigger : MonoBehaviour
	{
		// Token: 0x060020AA RID: 8362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020AA")]
		[Address(RVA = "0x331BB00", Offset = "0x331A100", VA = "0x18331BB00")]
		private void OnValidate()
		{
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AB")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		private LinkActivateDirectionalTrigger GetController()
		{
			return null;
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020AC")]
		[Address(RVA = "0x331C060", Offset = "0x331A660", VA = "0x18331C060")]
		private void RefreshAutoCollect(bool ignoreHiddenInCollection)
		{
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020AD")]
		[Address(RVA = "0x331C4D0", Offset = "0x331AAD0", VA = "0x18331C4D0")]
		private void OnEnable()
		{
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020AE")]
		[Address(RVA = "0x331C5B0", Offset = "0x331ABB0", VA = "0x18331C5B0")]
		private void Initialize()
		{
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020AF")]
		[Address(RVA = "0x331C5C0", Offset = "0x331ABC0", VA = "0x18331C5C0")]
		private void OnExitedAEvent(GameObject obj)
		{
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B0")]
		[Address(RVA = "0x331C5B0", Offset = "0x331ABB0", VA = "0x18331C5B0")]
		private void OnExitedBEvent(GameObject obj)
		{
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B1")]
		[Address(RVA = "0x331C5D0", Offset = "0x331ABD0", VA = "0x18331C5D0")]
		private void OnEnter()
		{
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B2")]
		[Address(RVA = "0x331C6D0", Offset = "0x331ACD0", VA = "0x18331C6D0")]
		private void OnExit()
		{
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B3")]
		[Address(RVA = "0x331C7E0", Offset = "0x331ADE0", VA = "0x18331C7E0")]
		private static void ListActivate(List<GameObject> targetList, bool value)
		{
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B4")]
		[Address(RVA = "0x331CA40", Offset = "0x331B040", VA = "0x18331CA40")]
		public LinkActivateDirectionalTrigger()
		{
		}

		// Token: 0x04001E67 RID: 7783
		[Token(Token = "0x4001E67")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DirectionalTrigger _source;

		// Token: 0x04001E68 RID: 7784
		[Token(Token = "0x4001E68")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LinkActivateDirectionalTrigger _controllerTrigger;

		// Token: 0x04001E69 RID: 7785
		[Token(Token = "0x4001E69")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _collectFromScene;

		// Token: 0x04001E6A RID: 7786
		[Token(Token = "0x4001E6A")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _ignoreHiddenInCollection;

		// Token: 0x04001E6B RID: 7787
		[Token(Token = "0x4001E6B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _ignoreCollect;

		// Token: 0x04001E6C RID: 7788
		[Token(Token = "0x4001E6C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<GameObject> _onEnterActivate;

		// Token: 0x04001E6D RID: 7789
		[Token(Token = "0x4001E6D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<GameObject> _onEnterDeactivate;

		// Token: 0x04001E6E RID: 7790
		[Token(Token = "0x4001E6E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _mirror;

		// Token: 0x04001E6F RID: 7791
		[Token(Token = "0x4001E6F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<GameObject> _onExitActivate;

		// Token: 0x04001E70 RID: 7792
		[Token(Token = "0x4001E70")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<GameObject> _onExitDeactivate;

		// Token: 0x04001E71 RID: 7793
		[Token(Token = "0x4001E71")]
		[FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[SerializeField]
		private bool _hasControllerTrigger;
	}
}
