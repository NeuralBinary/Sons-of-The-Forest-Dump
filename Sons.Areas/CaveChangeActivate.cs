using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Sons.Areas
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[AddComponentMenu("Sons/World/Cave Changed Activate")]
	public class CaveChangeActivate : MonoBehaviour
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnValidate()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2D26AB0", Offset = "0x2D250B0", VA = "0x182D26AB0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2D26C40", Offset = "0x2D25240", VA = "0x182D26C40")]
		public void OnAreaMaskChanged(AreaMask oldAreaMask, AreaMask newAreaMask, PlayerType playerType)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2D26D30", Offset = "0x2D25330", VA = "0x182D26D30")]
		private void ToggleEnabled(PlayerType playerType)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2D26DB0", Offset = "0x2D253B0", VA = "0x182D26DB0")]
		private void ToggleDisabled(PlayerType playerType)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2D26E80", Offset = "0x2D25480", VA = "0x182D26E80")]
		private void ToggleList(List<GameObject> targetList, bool value)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2D27070", Offset = "0x2D25670", VA = "0x182D27070")]
		private void OnDisable()
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2A96EC0", Offset = "0x2A954C0", VA = "0x182A96EC0")]
		public CaveChangeActivate()
		{
		}

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("_caveFilter")]
		private AreaMask _areaFilter;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _triggerCaveExitedOnEnable;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("_enableOnEntered")]
		private List<GameObject> _enableOnEnteredLocal;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("_disableOnEntered")]
		[SerializeField]
		private List<GameObject> _disableOnEnteredLocal;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent _triggerOnEnteredLocal;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<GameObject> _enableOnEnteredAny;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<GameObject> _disableOnEnteredAny;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UnityEvent _triggerOnEnteredAny;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _mirror;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<GameObject> _enableOnExitedLocal;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<GameObject> _disableOnExitedLocal;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UnityEvent _triggerOnExitedLocal;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[FormerlySerializedAs("_enableOnExited")]
		private List<GameObject> _enableOnExitedAny;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[FormerlySerializedAs("_disableOnExited")]
		private List<GameObject> _disableOnExitedAny;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UnityEvent _triggerOnExitedAny;
	}
}
