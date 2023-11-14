import styled from 'styled-components';

export const Container = styled.div`
    align-items: center;
    background-color: #19144a;
    color: #fff;
    display: flex;
    height:100vh;
    justify-content: center;
    width:100%;
`;

export const Content = styled.div`
    padding: 16px;
    background-color: #191970;
    -webkit-box-shadow: 16px 15px 21px 6px rgba(14,6,24,0.62); 
    box-shadow: 16px 15px 21px 6px rgba(14,6,24,0.62);
    border-radius:16px;
    width: 80%;
`;

export const Row = styled.div`
    display: flex;
    flex-direction:row;
    justify-content:space-between;
    align-items: center;
`;