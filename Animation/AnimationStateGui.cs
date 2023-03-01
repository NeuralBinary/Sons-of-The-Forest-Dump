using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x02000886 RID: 2182
	[Token(Token = "0x2000886")]
	public class AnimationStateGui : MonoBehaviour
	{
		// Token: 0x06003AFE RID: 15102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AFE")]
		[Address(RVA = "0x2EF7B30", Offset = "0x2EF6B30", VA = "0x182EF7B30")]
		public static void SetDebugAll(bool value)
		{
		}

		// Token: 0x06003AFF RID: 15103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AFF")]
		[Address(RVA = "0x2EF6610", Offset = "0x2EF5610", VA = "0x182EF6610")]
		private void Awake()
		{
		}

		// Token: 0x06003B00 RID: 15104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B00")]
		[Address(RVA = "0x2EF7580", Offset = "0x2EF6580", VA = "0x182EF7580")]
		private void OnGUI()
		{
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B01")]
		[Address(RVA = "0x2EF6E90", Offset = "0x2EF5E90", VA = "0x182EF6E90")]
		private void DrawStateInfo(AnimationStateGui target, ref int row, List<string> stateNames, List<int> stateNameHashes)
		{
		}

		// Token: 0x06003B02 RID: 15106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B02")]
		[Address(RVA = "0x2EF74D0", Offset = "0x2EF64D0", VA = "0x182EF74D0")]
		private static string GetStateName(int shortNameHash, List<string> stateNames, List<int> stateNameHashes)
		{
			return null;
		}

		// Token: 0x06003B03 RID: 15107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B03")]
		[Address(RVA = "0x2EF6BC0", Offset = "0x2EF5BC0", VA = "0x182EF6BC0")]
		private static void DrawStateInfo(Vector3 screenPos, int row, string labelText, int layerIndex, float labelHeight, float normalizedTime, float itemWidth)
		{
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B04")]
		[Address(RVA = "0x2EF7A30", Offset = "0x2EF6A30", VA = "0x182EF7A30")]
		private static string ProcessStateLabel(string currentLabelText, int layerIndex, float normalizedTime)
		{
			return null;
		}

		// Token: 0x06003B05 RID: 15109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B05")]
		[Address(RVA = "0x2EF6A70", Offset = "0x2EF5A70", VA = "0x182EF6A70")]
		private static void DrawProgress(Vector3 screenPos, int row, float labelHeight, float itemWidth, float normalizedTime)
		{
		}

		// Token: 0x06003B06 RID: 15110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B06")]
		[Address(RVA = "0x2EF68A0", Offset = "0x2EF58A0", VA = "0x182EF68A0")]
		private void DrawLayerWeight(Vector3 screenPos, int row, float labelHeight, float layerWeight)
		{
		}

		// Token: 0x06003B07 RID: 15111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B07")]
		[Address(RVA = "0x2EF6760", Offset = "0x2EF5760", VA = "0x182EF6760")]
		private static void DrawLabel(Vector3 screenPos, int row, float labelHeight, float itemWidth, string labelText)
		{
		}

		// Token: 0x06003B08 RID: 15112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B08")]
		[Address(RVA = "0x2EF7CF0", Offset = "0x2EF6CF0", VA = "0x182EF7CF0")]
		public AnimationStateGui()
		{
		}

		// Token: 0x04003F50 RID: 16208
		[Token(Token = "0x4003F50")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GUISkin _skinSource;

		// Token: 0x04003F51 RID: 16209
		[Token(Token = "0x4003F51")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator _targetAnimator;

		// Token: 0x04003F52 RID: 16210
		[Token(Token = "0x4003F52")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _hideInactiveLayers;

		// Token: 0x04003F53 RID: 16211
		[Token(Token = "0x4003F53")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Color _layerOffColor;

		// Token: 0x04003F54 RID: 16212
		[Token(Token = "0x4003F54")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Color _layerOnColor;

		// Token: 0x04003F55 RID: 16213
		[Token(Token = "0x4003F55")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private bool _drawGui;

		// Token: 0x04003F56 RID: 16214
		[Token(Token = "0x4003F56")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<int> _stateNameHashes;

		// Token: 0x04003F57 RID: 16215
		[Token(Token = "0x4003F57")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<string> _stateNames;

		// Token: 0x04003F58 RID: 16216
		[Token(Token = "0x4003F58")]
		[FieldOffset(Offset = "0x68")]
		private List<float> _layerNormalizedTimes;

		// Token: 0x04003F59 RID: 16217
		[Token(Token = "0x4003F59")]
		[FieldOffset(Offset = "0x0")]
		private static bool _debugDrawAll;

		// Token: 0x04003F5A RID: 16218
		[Token(Token = "0x4003F5A")]
		[FieldOffset(Offset = "0x4")]
		private static int _frameCount;

		// Token: 0x04003F5B RID: 16219
		[Token(Token = "0x4003F5B")]
		[FieldOffset(Offset = "0x8")]
		private static int _debugIndex;

		// Token: 0x04003F5C RID: 16220
		[Token(Token = "0x4003F5C")]
		[FieldOffset(Offset = "0x10")]
		private static readonly List<Animator> _debugDrawnAnimators;

		// Token: 0x04003F5D RID: 16221
		[Token(Token = "0x4003F5D")]
		[FieldOffset(Offset = "0x18")]
		private static bool _registeredDebug;

		// Token: 0x04003F5E RID: 16222
		[Token(Token = "0x4003F5E")]
		[FieldOffset(Offset = "0x20")]
		private static GUIStyle _labelSkin;

		// Token: 0x04003F5F RID: 16223
		[Token(Token = "0x4003F5F")]
		[FieldOffset(Offset = "0x28")]
		private static GUIStyle _sliderSkin;

		// Token: 0x04003F60 RID: 16224
		[Token(Token = "0x4003F60")]
		[FieldOffset(Offset = "0x30")]
		private static GUIStyle _thumbSkin;

		// Token: 0x04003F61 RID: 16225
		[Token(Token = "0x4003F61")]
		[FieldOffset(Offset = "0x38")]
		private static GUIStyle _weightSkin;

		// Token: 0x04003F62 RID: 16226
		[Token(Token = "0x4003F62")]
		[FieldOffset(Offset = "0x40")]
		private static Color _backgroundColor;

		// Token: 0x04003F63 RID: 16227
		[Token(Token = "0x4003F63")]
		[FieldOffset(Offset = "0x70")]
		private float _labelHeight;

		// Token: 0x04003F64 RID: 16228
		[Token(Token = "0x4003F64")]
		[FieldOffset(Offset = "0x74")]
		private float _itemWidth;

		// Token: 0x04003F65 RID: 16229
		[Token(Token = "0x4003F65")]
		[FieldOffset(Offset = "0x78")]
		private int _labelStyleIndex;

		// Token: 0x04003F66 RID: 16230
		[Token(Token = "0x4003F66")]
		[FieldOffset(Offset = "0x7C")]
		private int _sliderStyleIndex;

		// Token: 0x04003F67 RID: 16231
		[Token(Token = "0x4003F67")]
		[FieldOffset(Offset = "0x80")]
		private int _thumbStyleIndex;

		// Token: 0x04003F68 RID: 16232
		[Token(Token = "0x4003F68")]
		[FieldOffset(Offset = "0x84")]
		private int _weightSkinIndex;
	}
}
