using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace RootMotion.FinalIK
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionObject : MonoBehaviour
	{
		// Token: 0x060004B4 RID: 1204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x29762B0", Offset = "0x29748B0", VA = "0x1829762B0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x2976340", Offset = "0x2974940", VA = "0x182976340")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x29763D0", Offset = "0x29749D0", VA = "0x1829763D0")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x2976460", Offset = "0x2974A60", VA = "0x182976460")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x29764F0", Offset = "0x2974AF0", VA = "0x1829764F0")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x2976580", Offset = "0x2974B80", VA = "0x182976580")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x2976610", Offset = "0x2974C10", VA = "0x182976610")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x29766A0", Offset = "0x2974CA0", VA = "0x1829766A0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00003DF4 File Offset: 0x00001FF4
		// (set) Token: 0x060004BD RID: 1213 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000086")]
		public float length
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x23A8BF0", Offset = "0x23A71F0", VA = "0x1823A8BF0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x290B500", Offset = "0x2909B00", VA = "0x18290B500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000087")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x2976730", Offset = "0x2974D30", VA = "0x182976730")]
		public void Initiate()
		{
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000088")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x29769C0", Offset = "0x2974FC0", VA = "0x1829769C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x2976AD0", Offset = "0x29750D0", VA = "0x182976AD0")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00003E0C File Offset: 0x0000200C
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x2976CB0", Offset = "0x29752B0", VA = "0x182976CB0")]
		public bool CurveUsed(InteractionObject.WeightCurve.Type type)
		{
			return default(bool);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x2976D50", Offset = "0x2975350", VA = "0x182976D50")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x2976FA0", Offset = "0x29755A0", VA = "0x182976FA0")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00003E24 File Offset: 0x00002024
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x2977520", Offset = "0x2975B20", VA = "0x182977520")]
		public float GetValue(InteractionObject.WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return 0f;
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000089")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x2977840", Offset = "0x2975E40", VA = "0x182977840")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x2977950", Offset = "0x2975F50", VA = "0x182977950")]
		private void Start()
		{
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x2977960", Offset = "0x2975F60", VA = "0x182977960")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionObject.WeightCurve.Type type, float value, float weight)
		{
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x29781B0", Offset = "0x29767B0", VA = "0x1829781B0")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00003E3C File Offset: 0x0000203C
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x2978270", Offset = "0x2976870", VA = "0x182978270")]
		private int GetWeightCurveIndex(InteractionObject.WeightCurve.Type weightCurveType)
		{
			return 0;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00003E54 File Offset: 0x00002054
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x29782D0", Offset = "0x29768D0", VA = "0x1829782D0")]
		private int GetMultiplierIndex(InteractionObject.WeightCurve.Type weightCurveType)
		{
			return 0;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x2978330", Offset = "0x2976930", VA = "0x182978330")]
		public InteractionObject()
		{
		}

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x38")]
		public InteractionObject.WeightCurve[] weightCurves;

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x40")]
		public InteractionObject.Multiplier[] multipliers;

		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x48")]
		public InteractionObject.InteractionEvent[] events;

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x60")]
		private InteractionTarget[] targets;

		// Token: 0x02000085 RID: 133
		[Token(Token = "0x2000085")]
		[Serializable]
		public class InteractionEvent
		{
			// Token: 0x060004D0 RID: 1232 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x29783F0", Offset = "0x29769F0", VA = "0x1829783F0")]
			public void Activate(Transform t)
			{
			}

			// Token: 0x060004D1 RID: 1233 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public InteractionEvent()
			{
			}

			// Token: 0x04000459 RID: 1113
			[Token(Token = "0x4000459")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			// Token: 0x0400045A RID: 1114
			[Token(Token = "0x400045A")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			// Token: 0x0400045B RID: 1115
			[Token(Token = "0x400045B")]
			[FieldOffset(Offset = "0x15")]
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			// Token: 0x0400045C RID: 1116
			[Token(Token = "0x400045C")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("The animations called on this event.")]
			public InteractionObject.AnimatorEvent[] animations;

			// Token: 0x0400045D RID: 1117
			[Token(Token = "0x400045D")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public InteractionObject.Message[] messages;

			// Token: 0x0400045E RID: 1118
			[Token(Token = "0x400045E")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;
		}

		// Token: 0x02000086 RID: 134
		[Token(Token = "0x2000086")]
		[Serializable]
		public class Message
		{
			// Token: 0x060004D2 RID: 1234 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x29784C0", Offset = "0x2976AC0", VA = "0x1829784C0")]
			public void Send(Transform t)
			{
			}

			// Token: 0x060004D3 RID: 1235 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Message()
			{
			}

			// Token: 0x0400045F RID: 1119
			[Token(Token = "0x400045F")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("The name of the function called.")]
			public string function;

			// Token: 0x04000460 RID: 1120
			[Token(Token = "0x4000460")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			// Token: 0x04000461 RID: 1121
			[Token(Token = "0x4000461")]
			private const string empty = "";
		}

		// Token: 0x02000087 RID: 135
		[Token(Token = "0x2000087")]
		[Serializable]
		public class AnimatorEvent
		{
			// Token: 0x060004D4 RID: 1236 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x2978660", Offset = "0x2976C60", VA = "0x182978660")]
			public void Activate(bool pickUp)
			{
			}

			// Token: 0x060004D5 RID: 1237 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x29789F0", Offset = "0x2976FF0", VA = "0x1829789F0")]
			private void Activate(Animator animator)
			{
			}

			// Token: 0x060004D6 RID: 1238 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x2978AC0", Offset = "0x29770C0", VA = "0x182978AC0")]
			private void Activate(Animation animation)
			{
			}

			// Token: 0x060004D7 RID: 1239 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x2978C40", Offset = "0x2977240", VA = "0x182978C40")]
			public AnimatorEvent()
			{
			}

			// Token: 0x04000462 RID: 1122
			[Token(Token = "0x4000462")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			// Token: 0x04000463 RID: 1123
			[Token(Token = "0x4000463")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			// Token: 0x04000464 RID: 1124
			[Token(Token = "0x4000464")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("The name of the animation state.")]
			public string animationState;

			// Token: 0x04000465 RID: 1125
			[Token(Token = "0x4000465")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			// Token: 0x04000466 RID: 1126
			[Token(Token = "0x4000466")]
			[FieldOffset(Offset = "0x2C")]
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			// Token: 0x04000467 RID: 1127
			[Token(Token = "0x4000467")]
			[FieldOffset(Offset = "0x30")]
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			// Token: 0x04000468 RID: 1128
			[Token(Token = "0x4000468")]
			private const string empty = "";
		}

		// Token: 0x02000088 RID: 136
		[Token(Token = "0x2000088")]
		[Serializable]
		public class WeightCurve
		{
			// Token: 0x060004D8 RID: 1240 RVA: 0x00003E6C File Offset: 0x0000206C
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x2978C50", Offset = "0x2977250", VA = "0x182978C50")]
			public float GetValue(float timer)
			{
				return 0f;
			}

			// Token: 0x060004D9 RID: 1241 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public WeightCurve()
			{
			}

			// Token: 0x04000469 RID: 1129
			[Token(Token = "0x4000469")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type type;

			// Token: 0x0400046A RID: 1130
			[Token(Token = "0x400046A")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			// Token: 0x02000089 RID: 137
			[Token(Token = "0x2000089")]
			[Serializable]
			public enum Type
			{
				// Token: 0x0400046C RID: 1132
				[Token(Token = "0x400046C")]
				PositionWeight,
				// Token: 0x0400046D RID: 1133
				[Token(Token = "0x400046D")]
				RotationWeight,
				// Token: 0x0400046E RID: 1134
				[Token(Token = "0x400046E")]
				PositionOffsetX,
				// Token: 0x0400046F RID: 1135
				[Token(Token = "0x400046F")]
				PositionOffsetY,
				// Token: 0x04000470 RID: 1136
				[Token(Token = "0x4000470")]
				PositionOffsetZ,
				// Token: 0x04000471 RID: 1137
				[Token(Token = "0x4000471")]
				Pull,
				// Token: 0x04000472 RID: 1138
				[Token(Token = "0x4000472")]
				Reach,
				// Token: 0x04000473 RID: 1139
				[Token(Token = "0x4000473")]
				RotateBoneWeight,
				// Token: 0x04000474 RID: 1140
				[Token(Token = "0x4000474")]
				Push,
				// Token: 0x04000475 RID: 1141
				[Token(Token = "0x4000475")]
				PushParent,
				// Token: 0x04000476 RID: 1142
				[Token(Token = "0x4000476")]
				PoserWeight,
				// Token: 0x04000477 RID: 1143
				[Token(Token = "0x4000477")]
				BendGoalWeight
			}
		}

		// Token: 0x0200008A RID: 138
		[Token(Token = "0x200008A")]
		[Serializable]
		public class Multiplier
		{
			// Token: 0x060004DA RID: 1242 RVA: 0x00003E84 File Offset: 0x00002084
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x2978CC0", Offset = "0x29772C0", VA = "0x182978CC0")]
			public float GetValue(InteractionObject.WeightCurve weightCurve, float timer)
			{
				return 0f;
			}

			// Token: 0x060004DB RID: 1243 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x6C1AF0", Offset = "0x6C00F0", VA = "0x1806C1AF0")]
			public Multiplier()
			{
			}

			// Token: 0x04000478 RID: 1144
			[Token(Token = "0x4000478")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type to multiply.")]
			public InteractionObject.WeightCurve.Type curve;

			// Token: 0x04000479 RID: 1145
			[Token(Token = "0x4000479")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			// Token: 0x0400047A RID: 1146
			[Token(Token = "0x400047A")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("The resulting value will be applied to this channel.")]
			public InteractionObject.WeightCurve.Type result;
		}
	}
}
