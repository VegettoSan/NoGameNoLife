using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IkFoot : MonoBehaviour
{
    public Animator anim;
    private Vector3 rightFootPosition, leftFootPosition, rightFootIkPosition, leftFootIkPosition;
    private Quaternion rightFootIkRotation, leftFootIkRotation;
    private float lastPelvisPositionY, lastRightFootPositionY, lastLeftFootPositionY;

    [Header("Feet Grounder")]
    public bool enabledFeet = true;
    [Range(0f, 2f)] [SerializeField] private float heightFromGroundRaycast = 1.14f;
    [Range(0f, 2f)] [SerializeField] private float raycastDownDistance = 1.5f;
    [SerializeField] private LayerMask evironmentLayer;
    [SerializeField] private float pelvisOffset = 0f;
    [Range(0f, 1f)] [SerializeField] private float pelvisUpAndDownSpeed = 0.28f;
    [Range(0f, 1f)] [SerializeField] private float feetToIkPositionSpeed = 0.5f;

    public string leftFootAnimVariableName = "LeftFootCurve";
    public string rightFootAnimVariableName = "rightFootCurve";

    public bool useProIkFeature = false;
    public bool showSolverDebug = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(enabledFeet == false)
        {
            return;
        }

        if (anim = null)
        {
            return;
        }

        AdjustFeetTarget(ref rightFootPosition, HumanBodyBones.RightFoot);
        AdjustFeetTarget(ref leftFootPosition, HumanBodyBones.LeftFoot);

        FeetPositionSolver(rightFootPosition, ref rightFootIkPosition, ref rightFootIkRotation);
        FeetPositionSolver(leftFootPosition, ref leftFootIkPosition, ref leftFootIkRotation);
    }
    private void OnAnimatorIK(int layerIndex)
    {
        if (enabledFeet == false)
        {
            return;
        }

        if (anim = null)
        {
            return;
        }

        MovePelvisHeight();

        anim.SetIKPositionWeight(AvatarIKGoal.RightFoot, 1);

        if (useProIkFeature)
        {
            anim.SetIKRotationWeight(AvatarIKGoal.RightFoot, anim.GetFloat(rightFootAnimVariableName));
        }

        MoveFeetToIkPoint(AvatarIKGoal.RightFoot, rightFootIkPosition, rightFootIkRotation, ref lastRightFootPositionY);

        anim.SetIKPositionWeight(AvatarIKGoal.LeftFoot, 1);

        if (useProIkFeature)
        {
            anim.SetIKRotationWeight(AvatarIKGoal.LeftFoot, anim.GetFloat(leftFootAnimVariableName));
        }

        MoveFeetToIkPoint(AvatarIKGoal.LeftFoot, leftFootIkPosition, leftFootIkRotation, ref lastLeftFootPositionY);
    }

    void MoveFeetToIkPoint(AvatarIKGoal foot, Vector3 positionIkHolder, Quaternion rotationIkHolder, ref float lastFootPositionY)
    {
        Vector3 targetIkPosition = anim.GetIKPosition(foot);

        if (positionIkHolder != Vector3.zero)
        {
            targetIkPosition = transform.InverseTransformPoint(targetIkPosition);
            positionIkHolder = transform.InverseTransformPoint(positionIkHolder);

            float yVariable = Mathf.LerpAngle(lastFootPositionY, positionIkHolder.y, feetToIkPositionSpeed);
            targetIkPosition.y += yVariable;

            lastFootPositionY = yVariable;

            targetIkPosition = transform.TransformPoint(targetIkPosition);

            anim.SetIKRotation(foot, rotationIkHolder);
        }
        anim.SetIKPosition(foot, targetIkPosition);
    }

    private void MovePelvisHeight()
    {

    }

    void FeetPositionSolver(Vector3 fromSkyPosition, ref Vector3 feetIkPositions, ref Quaternion feetIkRotations)
    {

    }

    private void AdjustFeetTarget (ref Vector3 feetPositions, HumanBodyBones foot)
    {

    }
}
