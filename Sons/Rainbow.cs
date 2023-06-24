using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000088 RID: 136
[Token(Token = "0x2000088")]
public class Rainbow : MonoBehaviour
{
	// Token: 0x060004DC RID: 1244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x3371600", Offset = "0x336FC00", VA = "0x183371600")]
	private void OnDestroy()
	{
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x33716E0", Offset = "0x336FCE0", VA = "0x1833716E0")]
	private void OnEnable()
	{
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x33716F0", Offset = "0x336FCF0", VA = "0x1833716F0")]
	private void Initialize()
	{
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x33719D0", Offset = "0x336FFD0", VA = "0x1833719D0")]
	private void LateUpdate()
	{
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x000039C0 File Offset: 0x00001BC0
	[Token(Token = "0x60004E0")]
	[Address(RVA = "0x3372170", Offset = "0x3370770", VA = "0x183372170")]
	private bool ValidateCamera()
	{
		return default(bool);
	}

	// Token: 0x060004E1 RID: 1249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E1")]
	[Address(RVA = "0x3372360", Offset = "0x3370960", VA = "0x183372360")]
	public Rainbow()
	{
	}

	// Token: 0x0400040A RID: 1034
	[Token(Token = "0x400040A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Light _sunLight;

	// Token: 0x0400040B RID: 1035
	[Token(Token = "0x400040B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _rainbowDist;

	// Token: 0x0400040C RID: 1036
	[Token(Token = "0x400040C")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _scale;

	// Token: 0x0400040D RID: 1037
	[Token(Token = "0x400040D")]
	[FieldOffset(Offset = "0x30")]
	[Header("Rainbow Lighting")]
	[SerializeField]
	private float _lightMax;

	// Token: 0x0400040E RID: 1038
	[Token(Token = "0x400040E")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _lightMin;

	// Token: 0x0400040F RID: 1039
	[Token(Token = "0x400040F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _rainbowMax;

	// Token: 0x04000410 RID: 1040
	[Token(Token = "0x4000410")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _rainbowMin;

	// Token: 0x04000411 RID: 1041
	[Token(Token = "0x4000411")]
	[FieldOffset(Offset = "0x40")]
	private Material _rainbowMat;

	// Token: 0x04000412 RID: 1042
	[Token(Token = "0x4000412")]
	[FieldOffset(Offset = "0x48")]
	private float _rainBowFade;

	// Token: 0x04000413 RID: 1043
	[Token(Token = "0x4000413")]
	[FieldOffset(Offset = "0x50")]
	private HDAdditionalLightData _lightData;

	// Token: 0x04000414 RID: 1044
	[Token(Token = "0x4000414")]
	[FieldOffset(Offset = "0x58")]
	private Transform _camTrans;

	// Token: 0x04000415 RID: 1045
	[Token(Token = "0x4000415")]
	[FieldOffset(Offset = "0x60")]
	private Transform _lightTrans;

	// Token: 0x04000416 RID: 1046
	[Token(Token = "0x4000416")]
	[FieldOffset(Offset = "0x68")]
	private Transform _thisTrans;

	// Token: 0x04000417 RID: 1047
	[Token(Token = "0x4000417")]
	[FieldOffset(Offset = "0x70")]
	private Renderer _thisRend;

	// Token: 0x04000418 RID: 1048
	[Token(Token = "0x4000418")]
	[FieldOffset(Offset = "0x78")]
	private bool _isEnabled;

	// Token: 0x04000419 RID: 1049
	[Token(Token = "0x4000419")]
	private const float oneOverTan = 2.1902926f;

	// Token: 0x0400041A RID: 1050
	[Token(Token = "0x400041A")]
	private const float minusPiHalf = -1.5707964f;

	// Token: 0x0400041B RID: 1051
	[Token(Token = "0x400041B")]
	private const float threePiHalf = 4.712389f;

	// Token: 0x0400041C RID: 1052
	[Token(Token = "0x400041C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int UnlitColorPID;

	// Token: 0x0400041D RID: 1053
	[Token(Token = "0x400041D")]
	[FieldOffset(Offset = "0x79")]
	private bool _hasInitialized;
}
