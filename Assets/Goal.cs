using UnityEngine;

public class Goal : MonoBehaviour
{
    #region Publics
    public float m_goalValue;
    public float m_currentValue;
    public Gradient m_uncompletedGradient;
    public Gradient m_completedGradient;
    public GameObject m_winLabel;
    #endregion


    #region Unity Api
    private void Start()
    {
        m_lineRenderer = GetComponent<LineRenderer>();

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Entered");
        m_currentValue++;
        if (m_currentValue > m_goalValue)
        {
            m_lineRenderer.colorGradient = m_completedGradient;
            m_winLabel.SetActive(true);
        }
        else
        {
            m_lineRenderer.colorGradient = m_uncompletedGradient;
        }
    }
    #endregion


    #region Main Methods

    #endregion


    #region Utils

    #endregion


    #region Private and Protected
    private LineRenderer m_lineRenderer;
    #endregion


}
