using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x020008F8 RID: 2296
	[Token(Token = "0x20008F8")]
	public class AnimationStateGui : MonoBehaviour
	{
		// Token: 0x0600422A RID: 16938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600422A")]
		[Address(RVA = "0x3631360", Offset = "0x362F960", VA = "0x183631360")]
		public static void SetDebugAll(bool value)
		{
		}

		// Token: 0x0600422B RID: 16939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600422B")]
		[Address(RVA = "0x36313C0", Offset = "0x362F9C0", VA = "0x1836313C0")]
		private void Awake()
		{
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600422C")]
		[Address(RVA = "0x3631510", Offset = "0x362FB10", VA = "0x183631510")]
		private void OnGUI()
		{
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600422D")]
		[Address(RVA = "0x3631B30", Offset = "0x3630130", VA = "0x183631B30")]
		private void DrawStateInfo(AnimationStateGui target, ref int row, List<string> stateNames, List<int> stateNameHashes)
		{
		}

		// Token: 0x0600422E RID: 16942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600422E")]
		[Address(RVA = "0x3632130", Offset = "0x3630730", VA = "0x183632130")]
		private static string GetStateName(int shortNameHash, List<string> stateNames, List<int> stateNameHashes)
		{
			return null;
		}

		// Token: 0x0600422F RID: 16943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600422F")]
		[Address(RVA = "0x3632210", Offset = "0x3630810", VA = "0x183632210")]
		private static void DrawStateInfo(Vector3 screenPos, int row, string labelText, int layerIndex, float labelHeight, float normalizedTime, float itemWidth)
		{
		}

		// Token: 0x06004230 RID: 16944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004230")]
		[Address(RVA = "0x36325A0", Offset = "0x3630BA0", VA = "0x1836325A0")]
		private static string ProcessStateLabel(string currentLabelText, int layerIndex, float normalizedTime)
		{
			return null;
		}

		// Token: 0x06004231 RID: 16945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004231")]
		[Address(RVA = "0x36326A0", Offset = "0x3630CA0", VA = "0x1836326A0")]
		private static void DrawProgress(Vector3 screenPos, int row, float labelHeight, float itemWidth, float normalizedTime)
		{
		}

		// Token: 0x06004232 RID: 16946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004232")]
		[Address(RVA = "0x36328B0", Offset = "0x3630EB0", VA = "0x1836328B0")]
		private void DrawLayerWeight(Vector3 screenPos, int row, float labelHeight, float layerWeight)
		{
		}

		// Token: 0x06004233 RID: 16947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004233")]
		[Address(RVA = "0x3632AE0", Offset = "0x36310E0", VA = "0x183632AE0")]
		private static void DrawLabel(Vector3 screenPos, int row, float labelHeight, float itemWidth, string labelText)
		{
		}

		// Token: 0x06004234 RID: 16948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004234")]
		[Address(RVA = "0x3632C80", Offset = "0x3631280", VA = "0x183632C80")]
		public AnimationStateGui()
		{
		}

		// Token: 0x0400457B RID: 17787
		[Token(Token = "0x400457B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GUISkin _skinSource;

		// Token: 0x0400457C RID: 17788
		[Token(Token = "0x400457C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator _targetAnimator;

		// Token: 0x0400457D RID: 17789
		[Token(Token = "0x400457D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _hideInactiveLayers;

		// Token: 0x0400457E RID: 17790
		[Token(Token = "0x400457E")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Color _layerOffColor;

		// Token: 0x0400457F RID: 17791
		[Token(Token = "0x400457F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Color _layerOnColor;

		// Token: 0x04004580 RID: 17792
		[Token(Token = "0x4004580")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private bool _drawGui;

		// Token: 0x04004581 RID: 17793
		[Token(Token = "0x4004581")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<int> _stateNameHashes;

		// Token: 0x04004582 RID: 17794
		[Token(Token = "0x4004582")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<string> _stateNames;

		// Token: 0x04004583 RID: 17795
		[Token(Token = "0x4004583")]
		[FieldOffset(Offset = "0x68")]
		private List<float> _layerNormalizedTimes;

		// Token: 0x04004584 RID: 17796
		[Token(Token = "0x4004584")]
		[FieldOffset(Offset = "0x0")]
		private static bool _debugDrawAll;

		// Token: 0x04004585 RID: 17797
		[Token(Token = "0x4004585")]
		[FieldOffset(Offset = "0x4")]
		private static int _frameCount;

		// Token: 0x04004586 RID: 17798
		[Token(Token = "0x4004586")]
		[FieldOffset(Offset = "0x8")]
		private static int _debugIndex;

		// Token: 0x04004587 RID: 17799
		[Token(Token = "0x4004587")]
		[FieldOffset(Offset = "0x10")]
		private static readonly List<Animator> _debugDrawnAnimators;

		// Token: 0x04004588 RID: 17800
		[Token(Token = "0x4004588")]
		[FieldOffset(Offset = "0x18")]
		private static bool _registeredDebug;

		// Token: 0x04004589 RID: 17801
		[Token(Token = "0x4004589")]
		[FieldOffset(Offset = "0x20")]
		private static GUIStyle _labelSkin;

		// Token: 0x0400458A RID: 17802
		[Token(Token = "0x400458A")]
		[FieldOffset(Offset = "0x28")]
		private static GUIStyle _sliderSkin;

		// Token: 0x0400458B RID: 17803
		[Token(Token = "0x400458B")]
		[FieldOffset(Offset = "0x30")]
		private static GUIStyle _thumbSkin;

		// Token: 0x0400458C RID: 17804
		[Token(Token = "0x400458C")]
		[FieldOffset(Offset = "0x38")]
		private static GUIStyle _weightSkin;

		// Token: 0x0400458D RID: 17805
		[Token(Token = "0x400458D")]
		[FieldOffset(Offset = "0x40")]
		private static Color _backgroundColor;

		// Token: 0x0400458E RID: 17806
		[Token(Token = "0x400458E")]
		[FieldOffset(Offset = "0x70")]
		private float _labelHeight;

		// Token: 0x0400458F RID: 17807
		[Token(Token = "0x400458F")]
		[FieldOffset(Offset = "0x74")]
		private float _itemWidth;

		// Token: 0x04004590 RID: 17808
		[Token(Token = "0x4004590")]
		[FieldOffset(Offset = "0x78")]
		private int _labelStyleIndex;

		// Token: 0x04004591 RID: 17809
		[Token(Token = "0x4004591")]
		[FieldOffset(Offset = "0x7C")]
		private int _sliderStyleIndex;

		// Token: 0x04004592 RID: 17810
		[Token(Token = "0x4004592")]
		[FieldOffset(Offset = "0x80")]
		private int _thumbStyleIndex;

		// Token: 0x04004593 RID: 17811
		[Token(Token = "0x4004593")]
		[FieldOffset(Offset = "0x84")]
		private int _weightSkinIndex;
	}
}
