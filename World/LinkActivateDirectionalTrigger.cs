using System;
using System.Collections.Generic;
using Endnight.Utilities;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.World
{
	// Token: 0x020004E8 RID: 1256
	[Token(Token = "0x20004E8")]
	[AddComponentMenu("Sons/Word/Directional Trigger (Link Activate)")]
	public class LinkActivateDirectionalTrigger : MonoBehaviour
	{
		// Token: 0x06002037 RID: 8247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002037")]
		[Address(RVA = "0x2D2AF80", Offset = "0x2D29F80", VA = "0x182D2AF80")]
		private void OnValidate()
		{
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002038")]
		[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
		private LinkActivateDirectionalTrigger GetController()
		{
			return null;
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002039")]
		[Address(RVA = "0x2D2B160", Offset = "0x2D2A160", VA = "0x182D2B160")]
		private void RefreshAutoCollect(bool ignoreHiddenInCollection)
		{
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600203A")]
		[Address(RVA = "0x2D2AD40", Offset = "0x2D29D40", VA = "0x182D2AD40")]
		private void OnEnable()
		{
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600203B")]
		[Address(RVA = "0x2D2AB60", Offset = "0x2D29B60", VA = "0x182D2AB60")]
		private void Initialize()
		{
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600203C")]
		[Address(RVA = "0x2D2AF70", Offset = "0x2D29F70", VA = "0x182D2AF70")]
		private void OnExitedAEvent(GameObject obj)
		{
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600203D")]
		[Address(RVA = "0x2D2AB60", Offset = "0x2D29B60", VA = "0x182D2AB60")]
		private void OnExitedBEvent(GameObject obj)
		{
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600203E")]
		[Address(RVA = "0x2D2AE20", Offset = "0x2D29E20", VA = "0x182D2AE20")]
		private void OnEnter()
		{
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600203F")]
		[Address(RVA = "0x2D2AEC0", Offset = "0x2D29EC0", VA = "0x182D2AEC0")]
		private void OnExit()
		{
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002040")]
		[Address(RVA = "0x2D2AB70", Offset = "0x2D29B70", VA = "0x182D2AB70")]
		private static void ListActivate(List<GameObject> targetList, bool value)
		{
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002041")]
		[Address(RVA = "0x2D2B3A0", Offset = "0x2D2A3A0", VA = "0x182D2B3A0")]
		public LinkActivateDirectionalTrigger()
		{
		}

		// Token: 0x04001E0C RID: 7692
		[Token(Token = "0x4001E0C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DirectionalTrigger _source;

		// Token: 0x04001E0D RID: 7693
		[Token(Token = "0x4001E0D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LinkActivateDirectionalTrigger _controllerTrigger;

		// Token: 0x04001E0E RID: 7694
		[Token(Token = "0x4001E0E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _collectFromScene;

		// Token: 0x04001E0F RID: 7695
		[Token(Token = "0x4001E0F")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _ignoreHiddenInCollection;

		// Token: 0x04001E10 RID: 7696
		[Token(Token = "0x4001E10")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _ignoreCollect;

		// Token: 0x04001E11 RID: 7697
		[Token(Token = "0x4001E11")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<GameObject> _onEnterActivate;

		// Token: 0x04001E12 RID: 7698
		[Token(Token = "0x4001E12")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<GameObject> _onEnterDeactivate;

		// Token: 0x04001E13 RID: 7699
		[Token(Token = "0x4001E13")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _mirror;

		// Token: 0x04001E14 RID: 7700
		[Token(Token = "0x4001E14")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<GameObject> _onExitActivate;

		// Token: 0x04001E15 RID: 7701
		[Token(Token = "0x4001E15")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<GameObject> _onExitDeactivate;

		// Token: 0x04001E16 RID: 7702
		[Token(Token = "0x4001E16")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[HideInInspector]
		private bool _hasControllerTrigger;
	}
}
