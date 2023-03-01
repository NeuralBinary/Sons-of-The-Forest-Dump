using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000089 RID: 137
[Token(Token = "0x2000089")]
public class Rainbow : MonoBehaviour
{
	// Token: 0x060004BD RID: 1213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x2D51E90", Offset = "0x2D50E90", VA = "0x182D51E90")]
	private void OnDestroy()
	{
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x2D51F20", Offset = "0x2D50F20", VA = "0x182D51F20")]
	private void OnEnable()
	{
	}

	// Token: 0x060004BF RID: 1215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x2D51710", Offset = "0x2D50710", VA = "0x182D51710")]
	private void Initialize()
	{
	}

	// Token: 0x060004C0 RID: 1216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x2D518E0", Offset = "0x2D508E0", VA = "0x182D518E0")]
	private void LateUpdate()
	{
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x00003828 File Offset: 0x00001A28
	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x2D51F30", Offset = "0x2D50F30", VA = "0x182D51F30")]
	private bool ValidateCamera()
	{
		return default(bool);
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x2D52060", Offset = "0x2D51060", VA = "0x182D52060")]
	public Rainbow()
	{
	}

	// Token: 0x040003EF RID: 1007
	[Token(Token = "0x40003EF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Light _sunLight;

	// Token: 0x040003F0 RID: 1008
	[Token(Token = "0x40003F0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _rainbowDist;

	// Token: 0x040003F1 RID: 1009
	[Token(Token = "0x40003F1")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _scale;

	// Token: 0x040003F2 RID: 1010
	[Token(Token = "0x40003F2")]
	[FieldOffset(Offset = "0x30")]
	[Header("Rainbow Lighting")]
	[SerializeField]
	private float _lightMax;

	// Token: 0x040003F3 RID: 1011
	[Token(Token = "0x40003F3")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _lightMin;

	// Token: 0x040003F4 RID: 1012
	[Token(Token = "0x40003F4")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _rainbowMax;

	// Token: 0x040003F5 RID: 1013
	[Token(Token = "0x40003F5")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _rainbowMin;

	// Token: 0x040003F6 RID: 1014
	[Token(Token = "0x40003F6")]
	[FieldOffset(Offset = "0x40")]
	private Material _rainbowMat;

	// Token: 0x040003F7 RID: 1015
	[Token(Token = "0x40003F7")]
	[FieldOffset(Offset = "0x48")]
	private float _rainBowFade;

	// Token: 0x040003F8 RID: 1016
	[Token(Token = "0x40003F8")]
	[FieldOffset(Offset = "0x50")]
	private HDAdditionalLightData _lightData;

	// Token: 0x040003F9 RID: 1017
	[Token(Token = "0x40003F9")]
	[FieldOffset(Offset = "0x58")]
	private Transform _camTrans;

	// Token: 0x040003FA RID: 1018
	[Token(Token = "0x40003FA")]
	[FieldOffset(Offset = "0x60")]
	private Transform _lightTrans;

	// Token: 0x040003FB RID: 1019
	[Token(Token = "0x40003FB")]
	[FieldOffset(Offset = "0x68")]
	private Transform _thisTrans;

	// Token: 0x040003FC RID: 1020
	[Token(Token = "0x40003FC")]
	[FieldOffset(Offset = "0x70")]
	private Renderer _thisRend;

	// Token: 0x040003FD RID: 1021
	[Token(Token = "0x40003FD")]
	[FieldOffset(Offset = "0x78")]
	private bool _isEnabled;

	// Token: 0x040003FE RID: 1022
	[Token(Token = "0x40003FE")]
	private const float oneOverTan = 2.1902926f;

	// Token: 0x040003FF RID: 1023
	[Token(Token = "0x40003FF")]
	private const float minusPiHalf = -1.5707964f;

	// Token: 0x04000400 RID: 1024
	[Token(Token = "0x4000400")]
	private const float threePiHalf = 4.712389f;

	// Token: 0x04000401 RID: 1025
	[Token(Token = "0x4000401")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int UnlitColorPID;

	// Token: 0x04000402 RID: 1026
	[Token(Token = "0x4000402")]
	[FieldOffset(Offset = "0x79")]
	private bool _hasInitialized;
}
