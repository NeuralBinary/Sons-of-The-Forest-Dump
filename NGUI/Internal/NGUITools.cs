using System;
using System.Diagnostics;
using Il2CppDummyDll;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Internal
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	public static class NGUITools
	{
		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00003C60 File Offset: 0x00001E60
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F3")]
		public static float soundVolume
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x2680710", Offset = "0x267ED10", VA = "0x182680710")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x2680820", Offset = "0x267EE20", VA = "0x182680820")]
			set
			{
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00003C78 File Offset: 0x00001E78
		[Token(Token = "0x170000F4")]
		public static bool fileAccess
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x26808E0", Offset = "0x267EEE0", VA = "0x1826808E0")]
		public static AudioSource PlaySound(AudioClip clip)
		{
			return null;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x2680940", Offset = "0x267EF40", VA = "0x182680940")]
		public static AudioSource PlaySound(AudioClip clip, float volume)
		{
			return null;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x26809B0", Offset = "0x267EFB0", VA = "0x1826809B0")]
		public static AudioSource PlaySound(AudioClip clip, float volume, float pitch)
		{
			return null;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00003C90 File Offset: 0x00001E90
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x2681450", Offset = "0x267FA50", VA = "0x182681450")]
		public static int RandomRange(int min, int max)
		{
			return 0;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x26814C0", Offset = "0x267FAC0", VA = "0x1826814C0")]
		public static string GetHierarchy(GameObject obj)
		{
			return null;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000455")]
		public static T[] FindActive<T>() where T : Component
		{
			return null;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x2681870", Offset = "0x267FE70", VA = "0x182681870")]
		public static Camera FindCameraForLayer(int layer)
		{
			return null;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x2681C80", Offset = "0x2680280", VA = "0x182681C80")]
		public static void AddWidgetCollider(GameObject go)
		{
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x2681CD0", Offset = "0x26802D0", VA = "0x182681CD0")]
		public static void AddWidgetCollider(GameObject go, bool considerInactive)
		{
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x2682320", Offset = "0x2680920", VA = "0x182682320")]
		public static void UpdateWidgetCollider(GameObject go)
		{
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x2682370", Offset = "0x2680970", VA = "0x182682370")]
		public static void UpdateWidgetCollider(GameObject go, bool considerInactive)
		{
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x26825F0", Offset = "0x2680BF0", VA = "0x1826825F0")]
		public static void UpdateWidgetCollider(BoxCollider box, bool considerInactive)
		{
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x2682C90", Offset = "0x2681290", VA = "0x182682C90")]
		public static void UpdateWidgetCollider(BoxCollider2D box, bool considerInactive)
		{
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600045D")]
		public static string GetTypeName<T>()
		{
			return null;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x2683010", Offset = "0x2681610", VA = "0x182683010")]
		public static string GetTypeName(UnityEngine.Object obj)
		{
			return null;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void RegisterUndo(UnityEngine.Object obj, string name)
		{
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void SetDirty(UnityEngine.Object obj)
		{
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x26831A0", Offset = "0x26817A0", VA = "0x1826831A0")]
		public static GameObject AddChild(GameObject parent)
		{
			return null;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x26831F0", Offset = "0x26817F0", VA = "0x1826831F0")]
		public static GameObject AddChild(GameObject parent, bool undo)
		{
			return null;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x26835B0", Offset = "0x2681BB0", VA = "0x1826835B0")]
		public static GameObject AddChild(GameObject parent, GameObject prefab)
		{
			return null;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x26839B0", Offset = "0x2681FB0", VA = "0x1826839B0")]
		public static int CalculateRaycastDepth(GameObject go)
		{
			return 0;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x2683BC0", Offset = "0x26821C0", VA = "0x182683BC0")]
		public static int CalculateNextDepth(GameObject go)
		{
			return 0;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x2683D10", Offset = "0x2682310", VA = "0x182683D10")]
		public static int CalculateNextDepth(GameObject go, bool ignoreChildrenWithColliders)
		{
			return 0;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00003CF0 File Offset: 0x00001EF0
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x26840D0", Offset = "0x26826D0", VA = "0x1826840D0")]
		public static int AdjustDepth(GameObject go, int adjustment)
		{
			return 0;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x26844D0", Offset = "0x2682AD0", VA = "0x1826844D0")]
		public static void BringForward(GameObject go)
		{
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x2684570", Offset = "0x2682B70", VA = "0x182684570")]
		public static void PushBack(GameObject go)
		{
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x2684610", Offset = "0x2682C10", VA = "0x182684610")]
		public static void NormalizeDepths()
		{
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x26846B0", Offset = "0x2682CB0", VA = "0x1826846B0")]
		public static void NormalizeWidgetDepths()
		{
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x2684710", Offset = "0x2682D10", VA = "0x182684710")]
		public static void NormalizeWidgetDepths(GameObject go)
		{
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x26847B0", Offset = "0x2682DB0", VA = "0x1826847B0")]
		public static void NormalizeWidgetDepths(UIWidget[] list)
		{
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x2684990", Offset = "0x2682F90", VA = "0x182684990")]
		public static void NormalizePanelDepths()
		{
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x2684BB0", Offset = "0x26831B0", VA = "0x182684BB0")]
		public static UIPanel CreateUI(bool advanced3D)
		{
			return null;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x2684C00", Offset = "0x2683200", VA = "0x182684C00")]
		public static UIPanel CreateUI(bool advanced3D, int layer)
		{
			return null;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x2684C60", Offset = "0x2683260", VA = "0x182684C60")]
		public static UIPanel CreateUI(Transform trans, bool advanced3D, int layer)
		{
			return null;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x26863D0", Offset = "0x26849D0", VA = "0x1826863D0")]
		public static void SetChildLayer(Transform t, int layer)
		{
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000473")]
		public static T AddChild<T>(GameObject parent) where T : Component
		{
			return null;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000474")]
		public static T AddChild<T>(GameObject parent, bool undo) where T : Component
		{
			return null;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000475")]
		public static T AddWidget<T>(GameObject go) where T : UIWidget
		{
			return null;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000476")]
		public static T AddWidget<T>(GameObject go, int depth) where T : UIWidget
		{
			return null;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x26865B0", Offset = "0x2684BB0", VA = "0x1826865B0")]
		public static UISprite AddSprite(GameObject go, UIAtlas atlas, string spriteName)
		{
			return null;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x2686740", Offset = "0x2684D40", VA = "0x182686740")]
		public static GameObject GetRoot(GameObject go)
		{
			return null;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000479")]
		public static T FindInParents<T>(GameObject go) where T : Component
		{
			return null;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600047A")]
		public static T FindInParents<T>(Transform trans) where T : Component
		{
			return null;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x26868F0", Offset = "0x2684EF0", VA = "0x1826868F0")]
		public static void Destroy(UnityEngine.Object obj)
		{
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x2686BD0", Offset = "0x26851D0", VA = "0x182686BD0")]
		public static void DestroyChildren(this Transform t)
		{
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x2686DA0", Offset = "0x26853A0", VA = "0x182686DA0")]
		public static void DestroyImmediate(UnityEngine.Object obj)
		{
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x2686EA0", Offset = "0x26854A0", VA = "0x182686EA0")]
		public static void Broadcast(string funcName)
		{
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x2687040", Offset = "0x2685640", VA = "0x182687040")]
		public static void Broadcast(string funcName, object param)
		{
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00003D08 File Offset: 0x00001F08
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x26871D0", Offset = "0x26857D0", VA = "0x1826871D0")]
		public static bool IsChild(Transform parent, Transform child)
		{
			return default(bool);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x2687440", Offset = "0x2685A40", VA = "0x182687440")]
		private static void Activate(Transform t)
		{
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x2687510", Offset = "0x2685B10", VA = "0x182687510")]
		private static void Activate(Transform t, bool compatibilityMode)
		{
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x2687800", Offset = "0x2685E00", VA = "0x182687800")]
		private static void Deactivate(Transform t)
		{
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x26878A0", Offset = "0x2685EA0", VA = "0x1826878A0")]
		public static void SetActive(GameObject go, bool state)
		{
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x2687900", Offset = "0x2685F00", VA = "0x182687900")]
		public static void SetActive(GameObject go, bool state, bool compatibilityMode)
		{
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x2687B10", Offset = "0x2686110", VA = "0x182687B10")]
		[DebuggerHidden]
		[DebuggerStepThrough]
		private static void CallCreatePanel(Transform t)
		{
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x2687CE0", Offset = "0x26862E0", VA = "0x182687CE0")]
		public static void SetActiveChildren(GameObject go, bool state)
		{
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x2688190", Offset = "0x2686790", VA = "0x182688190")]
		[Obsolete("Use NGUITools.GetActive instead")]
		public static bool IsActive(Behaviour mb)
		{
			return default(bool);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x2688320", Offset = "0x2686920", VA = "0x182688320")]
		[DebuggerHidden]
		[DebuggerStepThrough]
		public static bool GetActive(Behaviour mb)
		{
			return default(bool);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x2688500", Offset = "0x2686B00", VA = "0x182688500")]
		[DebuggerHidden]
		[DebuggerStepThrough]
		public static bool GetActive(GameObject go)
		{
			return default(bool);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x2688600", Offset = "0x2686C00", VA = "0x182688600")]
		[DebuggerHidden]
		[DebuggerStepThrough]
		public static void SetActiveSelf(GameObject go, bool state)
		{
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x26886B0", Offset = "0x2686CB0", VA = "0x1826886B0")]
		public static void SetLayer(GameObject go, int layer)
		{
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00003D68 File Offset: 0x00001F68
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x26888D0", Offset = "0x2686ED0", VA = "0x1826888D0")]
		public static Vector3 Round(Vector3 v)
		{
			return default(Vector3);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x2688950", Offset = "0x2686F50", VA = "0x182688950")]
		public static void MakePixelPerfect(Transform t)
		{
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00003D80 File Offset: 0x00001F80
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x2688E70", Offset = "0x2687470", VA = "0x182688E70")]
		public static bool Save(string fileName, byte[] bytes)
		{
			return default(bool);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x2688FE0", Offset = "0x26875E0", VA = "0x182688FE0")]
		public static byte[] Load(string fileName)
		{
			return null;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00003D98 File Offset: 0x00001F98
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x2689090", Offset = "0x2687690", VA = "0x182689090")]
		public static Color ApplyPMA(Color c)
		{
			return default(Color);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x26890D0", Offset = "0x26876D0", VA = "0x1826890D0")]
		public static void MarkParentAsChanged(GameObject go)
		{
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F5")]
		public static string clipboard
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x2689190", Offset = "0x2687790", VA = "0x182689190")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x2689200", Offset = "0x2687800", VA = "0x182689200")]
			set
			{
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x26892F0", Offset = "0x26878F0", VA = "0x1826892F0")]
		[Obsolete("Use NGUIText.EncodeColor instead")]
		public static string EncodeColor(Color c)
		{
			return null;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x2689350", Offset = "0x2687950", VA = "0x182689350")]
		[Obsolete("Use NGUIText.ParseColor instead")]
		public static Color ParseColor(string text, int offset)
		{
			return default(Color);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x26893D0", Offset = "0x26879D0", VA = "0x1826893D0")]
		[Obsolete("Use NGUIText.StripSymbols instead")]
		public static string StripSymbols(string text)
		{
			return null;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000498")]
		public static T AddMissingComponent<T>(this GameObject go) where T : Component
		{
			return null;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x2689420", Offset = "0x2687A20", VA = "0x182689420")]
		public static Vector3[] GetSides(this Camera cam)
		{
			return null;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x2689530", Offset = "0x2687B30", VA = "0x182689530")]
		public static Vector3[] GetSides(this Camera cam, float depth)
		{
			return null;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x2689590", Offset = "0x2687B90", VA = "0x182689590")]
		public static Vector3[] GetSides(this Camera cam, Transform relativeTo)
		{
			return null;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x26896B0", Offset = "0x2687CB0", VA = "0x1826896B0")]
		public static Vector3[] GetSides(this Camera cam, float depth, Transform relativeTo)
		{
			return null;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x268A180", Offset = "0x2688780", VA = "0x18268A180")]
		public static Vector3[] GetWorldCorners(this Camera cam)
		{
			return null;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x268A290", Offset = "0x2688890", VA = "0x18268A290")]
		public static Vector3[] GetWorldCorners(this Camera cam, float depth)
		{
			return null;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x268A2F0", Offset = "0x26888F0", VA = "0x18268A2F0")]
		public static Vector3[] GetWorldCorners(this Camera cam, Transform relativeTo)
		{
			return null;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x268A410", Offset = "0x2688A10", VA = "0x18268A410")]
		public static Vector3[] GetWorldCorners(this Camera cam, float depth, Transform relativeTo)
		{
			return null;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x268AE60", Offset = "0x2689460", VA = "0x18268AE60")]
		public static string GetFuncName(object obj, string method)
		{
			return null;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A2")]
		public static void Execute<T>(GameObject go, string funcName) where T : Component
		{
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A3")]
		public static void ExecuteAll<T>(GameObject root, string funcName) where T : Component
		{
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x268AF60", Offset = "0x2689560", VA = "0x18268AF60")]
		public static void ImmediatelyCreateDrawCalls(GameObject root)
		{
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x170000F6")]
		public static Vector2 screenSize
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x268B050", Offset = "0x2689650", VA = "0x18268B050")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x268B110", Offset = "0x2689710", VA = "0x18268B110")]
		public static string KeyToCaption(KeyCode key)
		{
			return null;
		}

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x0")]
		private static AudioListener mListener;

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x8")]
		private static bool mLoaded;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0xC")]
		private static float mGlobalVolume;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x10")]
		private static float mLastTimestamp;

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x18")]
		private static AudioClip mLastClip;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x20")]
		private static Vector3[] mSides;

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x28")]
		public static KeyCode[] keys;
	}
}
