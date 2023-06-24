using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000082")]
	[Serializable]
	public class InteractionEffector
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00003D1C File Offset: 0x00001F1C
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000081")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			[CompilerGenerated]
			get
			{
				return FullBodyBipedEffector.Body;
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00003D34 File Offset: 0x00001F34
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000082")]
		public bool isPaused
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x5FD560", Offset = "0x5FBB60", VA = "0x1805FD560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x5FD570", Offset = "0x5FBB70", VA = "0x1805FD570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000083")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00003D4C File Offset: 0x00001F4C
		[Token(Token = "0x17000084")]
		public bool inInteraction
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x2972830", Offset = "0x2970E30", VA = "0x182972830")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x29728F0", Offset = "0x2970EF0", VA = "0x1829728F0")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x29729B0", Offset = "0x2970FB0", VA = "0x1829729B0")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x2972B70", Offset = "0x2971170", VA = "0x182972B70")]
		private void StoreDefaults()
		{
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00003D64 File Offset: 0x00001F64
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x2972D60", Offset = "0x2971360", VA = "0x182972D60")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00003D7C File Offset: 0x00001F7C
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x2973220", Offset = "0x2971820", VA = "0x182973220")]
		public bool Pause()
		{
			return default(bool);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00003D94 File Offset: 0x00001F94
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x2973420", Offset = "0x2971A20", VA = "0x182973420")]
		public bool Resume()
		{
			return default(bool);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00003DAC File Offset: 0x00001FAC
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x2973480", Offset = "0x2971A80", VA = "0x182973480")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x2973E60", Offset = "0x2972460", VA = "0x182973E60")]
		public void Update(Transform root, float speed)
		{
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00003DC4 File Offset: 0x00001FC4
		[Token(Token = "0x17000085")]
		public float progress
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x29748F0", Offset = "0x2972EF0", VA = "0x1829748F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x2974930", Offset = "0x2972F30", VA = "0x182974930")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x2974BD0", Offset = "0x29731D0", VA = "0x182974BD0")]
		private void PickUp(Transform root)
		{
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00003DDC File Offset: 0x00001FDC
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x2974F80", Offset = "0x2973580", VA = "0x182974F80")]
		public bool Stop()
		{
			return default(bool);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x2975350", Offset = "0x2973950", VA = "0x182975350")]
		public void OnPostFBBIK()
		{
		}

		// Token: 0x04000427 RID: 1063
		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x20")]
		private Poser poser;

		// Token: 0x04000428 RID: 1064
		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0x30")]
		private float timer;

		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x34")]
		private float length;

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0x38")]
		private float weight;

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x48")]
		private float defaultPull;

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x50")]
		private float defaultPush;

		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		// Token: 0x04000436 RID: 1078
		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x68")]
		private bool defaults;

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0xB0")]
		private Transform target;

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0xC8")]
		private bool started;
	}
}
